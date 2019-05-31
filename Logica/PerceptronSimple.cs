using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logica
{
    public class PerceptronSimple
    {
        public string Nombre { get; set; }
        public int NumeroIteraciones { get; set; }
        public float RataAprendizaje { get; set; }
        public float ErrorMaximo { get; set; }
        public float[,] X { get; set; }
        public float[,] Yd { get; set; }
        public IEntrenamiento formEntrenamiento { get; set; }

        public PerceptronSimple(int numeroIteraciones, float rataAprendizaje, float errorMaximo, float[,] x, float[,] yd, IEntrenamiento form)
        {
            NumeroIteraciones = numeroIteraciones;
            RataAprendizaje = rataAprendizaje;
            ErrorMaximo = errorMaximo;
            X = x;
            Yd = yd;
            formEntrenamiento = form;
        }

        public PerceptronSimple()
        {
        }

        public int entrenar()
        {

            float sumaEl;
            float sumaEp;



            int m = X.GetLength(1);//entradas
            int n = Yd.GetLength(1);//salidas
            int patrones = Yd.GetLength(0);//patrones
            float[] El = new float[n];
            float[] Y = new float[n];
            float[] Ep = new float[patrones];
            float erms;
            float[] soma = new float[n];
            float[] U = new float[n];
            float[,] W = new float[m, n];
            var random = new Random(-1);


            List<float> listaErrores = new List<float>();
            List<float> listaErrorMaestro = new List<float>();

            float[,] listaPeso = new float[m, n];
            float[] listaumbrales = new float[n];


            for (int i = 0; i < n; i++)
            {
                U[i] = (float)random.NextDouble();
                Console.WriteLine(string.Format("U[{0}] = {1} %n", i, U[i]));
                Console.WriteLine("");
                for (int j = 0; j < m; j++)
                {
                    W[j, i] = (float)random.NextDouble();
                }
            }

            Console.WriteLine("Umbrales");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("U[{0}] = {1} \t", i, U[i]));
            }

            Console.WriteLine("Pesos");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(string.Format("W[{0},{1}] = {2} \t", j, i, W[j, i]));
                }
                Console.WriteLine("");
            }


            for (int e = 1; e <= NumeroIteraciones; e++)
            {
                sumaEl = 0;
                sumaEp = 0;
                erms = 0;
                for (int p = 0; p < patrones; p++)
                {

                    for (int i = 0; i < n; i++)
                    {
                        soma[i] = 0;
                        El[i] = 0;
                        for (int j = 0; j < m; j++)
                        {
                            soma[i] = soma[i] + X[p, j] * W[j, i];
                        }//ciclo de salidas

                        soma[i] = soma[i] + U[i];
                        Y[i] = activacion(soma[i]);
                        El[i] = Yd[p, i] - Y[i];
                        Console.WriteLine(string.Format("el[{0}]={1} - {2} ", i, Yd[p, i], Y[i]));
                        Console.WriteLine(string.Format("el[{0}]:{1} ", i, El[i]));
                        sumaEl = sumaEl + Math.Abs(El[i]);
                    }//ciclo entradas


                    //actualizacion de pesos y umbrales
                    for (int i = 0; i < n; i++)
                    {
                        U[i] = U[i] + RataAprendizaje * El[i];
                        listaumbrales[i] = U[i];
                        for (int j = 0; j < m; j++)
                        {
                            W[j, i] = W[j, i] + RataAprendizaje * El[i] * X[p, j];
                            listaPeso[j, i] = W[j, i];
                        }
                    }


                    formEntrenamiento.graficarPesosUmbrales(listaPeso, listaumbrales);
                    Console.WriteLine("Suma El " + sumaEl);
                    Ep[p] = sumaEl / patrones;
                    sumaEp = sumaEp + Ep[p];
                    Console.WriteLine(string.Format("Ep[{0}]: {1} ", p, Ep[p]));

                }//ciclo recorrido de patrones

                Console.WriteLine("Suma Ep " + sumaEp);
                erms = sumaEp / patrones;
                Console.WriteLine("iteraciones " + e);
                Console.WriteLine("ERMS " + erms);

                listaErrores.Add(erms);
                listaErrorMaestro.Add(ErrorMaximo);
                Thread.Sleep(1000);
                formEntrenamiento.graficarErrorIteracion(listaErrores, listaErrorMaestro);
                formEntrenamiento.mostrarErrrorIteracion(e, erms);
                formEntrenamiento.actualizarProgreso(e);
                if (erms <= ErrorMaximo)
                {
                    formEntrenamiento.actualizarProgreso(NumeroIteraciones);
                    formEntrenamiento.finalizarEntrenamiento(true);
                    guardar();
                    Console.WriteLine("iteraciones " + e);
                    return 1;
                }
                //Console.WriteLine(" ERROR ERMS "+sumaEp+"  "+e+" iteraciones");
                Console.WriteLine("\n");
            }
            formEntrenamiento.finalizarEntrenamiento(false);
            return 0;
        }

        private void guardar()
        {
            IEntrenamiento entrenamiento = this.formEntrenamiento;
            PerceptronSimple perceptronSimple = this;
            perceptronSimple.formEntrenamiento = null;

            string json = JsonConvert.SerializeObject(perceptronSimple);
            //obtenemos la carpeta y ejecutable de nuestra aplicación 
            string rutaFichero = Environment.GetCommandLineArgs()[0];
            //obtenemos sólo la carpeta (quitamos el ejecutable) 
            string carpeta = Path.GetDirectoryName(rutaFichero);
            //Montamos la carpeta y el fichero temporal con el 
            //primer parámetro que es el código de solicitud 
            rutaFichero = Path.Combine(carpeta, Nombre + ".json");
            try
            {
                //si no existe la carpeta temporal la creamos 
                if (!(Directory.Exists(carpeta)))
                {
                    Directory.CreateDirectory(carpeta);
                }

                if (Directory.Exists(carpeta))
                {
                    //Creamos el fichero temporal y 
                    //añadimos el texto pasado como parámetro 
                    System.IO.StreamWriter ficheroTemporal =
                        new System.IO.StreamWriter(rutaFichero);
                    ficheroTemporal.WriteLine(json);
                    ficheroTemporal.Close();
                }
            }
            catch (Exception errorC)
            {

            }
            this.formEntrenamiento = entrenamiento;
        }



        private float activacion(float v)
        {
            if (v > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
