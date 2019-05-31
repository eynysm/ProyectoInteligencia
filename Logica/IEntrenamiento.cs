using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IEntrenamiento
    {
        void graficarErrorIteracion(List<float> listaErroresIteracion, List<float> listaErrorMaximoPermitido);
        void graficarPesosUmbrales(float[,] matrizPesos, float[] vectorUmbrales);
        void actualizarProgreso(int i);
        void mostrarErrrorIteracion(int iteracion, float error);
        void finalizarEntrenamiento(bool estado);
    }
}
