using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class FrmEntrenamiento : Form, IEntrenamiento
    {
        public PerceptronSimple perceptronSimple { get; set; }

        public FrmEntrenamiento()
        {
            InitializeComponent();
            perceptronSimple = new PerceptronSimple();
        }

        public void graficarErrorIteracion(List<float> listaErrores, List<float> listaErrorMaestro)
        {
            //
            chartErrorIteracion.Series[0].Points.DataBindY(listaErrores);
            chartErrorIteracion.Series[1].Points.DataBindY(listaErrorMaestro);
            chartErrorIteracion.Update();
        }

        public void graficarPesosUmbrales(float[,] listaPesos, float[] listaUmbrales)
        {
            List<float> listaP = new List<float>();
            
            for (int i = 0; i < listaPesos.GetLength(0); i++)
            {
                
                for (int j = 0; j < listaPesos.GetLength(0); j++)
                {
                    listaP.Add(listaPesos[i, j]);
                }
            }

            List<float> listaU = new List<float>();
            for (int i = 0; i < listaUmbrales.Length; i++)
            {
				listaU.Add(listaUmbrales[i]);
            }
			// Pesosy Umbrales 
            
            chartPesosUmbrales.Series[0].Points.DataBindY(listaP);
			chartPesosUmbrales.Series[1].Points.DataBindY(listaU);
			chartPesosUmbrales.Update();


        }

        public void mostrarErrrorIteracion(int iteracion, float error)
        {
            lblRata.Text=$"Rata de Aprendizaje: { perceptronSimple.RataAprendizaje}";
            lblRata.Update();
            lblNumeroIteraciones.Text= $"Numero de Iteraciones: {perceptronSimple.NumeroIteraciones}";
            lblNumeroIteraciones.Update();
            lblErrorMaximo.Text= $"Error maximo Permitido: {perceptronSimple.ErrorMaximo}";
            lblErrorMaximo.Update();
            lblErrorIteracion.Text = $"Error Por Iteracion: {error}";
            lblErrorIteracion.Update();
            lblIIteracion.Text = $"Iteracion: {iteracion}";
            lblIIteracion.Update();
        }

        public void actualizarProgreso(int i)
        {
            progressBar1.Value = i;
        }

        public void finalizarEntrenamiento(bool estado)
        {
            if (estado == true)
            {
                MessageBox.Show("Entrenamiento finalizado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo entrenar la red");
            }
        }

        private void FrmEntrenamiento_Load(object sender, EventArgs e)
        {

        }

        internal void setPerceptronSimple(PerceptronSimple perceptronSimple)
        {
            this.perceptronSimple = perceptronSimple;
        }

        internal void iniciarEntrenamiento()
        {
            progressBar1.Maximum = perceptronSimple.NumeroIteraciones;
            perceptronSimple.entrenar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(perceptronSimple);
            // Path.Combine(Application.StartupPath, String.Format("Archivos\{0}", Path.GetFileName(openFileDialog1.FileName)));
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "ejemplo.json";
            // filtros
            save.Filter = "Archivo Json (*.json)|*.json|Todos los archivos (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(save.FileName);
                w.WriteLine(json);
                w.Close();
            }
        }

        private void ChartErrorIteracion_Click(object sender, EventArgs e)
        {

        }
    }
}
