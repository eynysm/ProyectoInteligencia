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
    public partial class FrmEntradasSalidas : Form
    {
        public PerceptronSimple perceptronSimple { get; set; }
        public FrmEntradasSalidas()
        {
            InitializeComponent();
            perceptronSimple = new PerceptronSimple();
        }

        private void FrmEntradasSalidas_Load(object sender, EventArgs e)
        {

        }

        public bool validarCampos()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && perceptronSimple != null)
            {
                perceptronSimple.Nombre = txtNombre.Text;
                return true;
            }
            MessageBox.Show("Hay campos vacios");
            return false;
        }

        private void btnEntradasSalidas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "archivo Json",
                Filter = "Json files (*.json)|*.json|Todos los archivos (*.*)|*.*",
                Title = "Abriendo archivo Json"
            };

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string json = File.ReadAllText(file);
                    perceptronSimple = JsonConvert.DeserializeObject<PerceptronSimple>(json);
                    cargarEntradasSalidasPatrones(perceptronSimple.X.GetLength(1), perceptronSimple.Yd.GetLength(1), perceptronSimple.X.GetLength(0));
                    cargarTablas();
                }
                catch (IOException)
                {
                }
            }
        }

        private void cargarTablas()
        {
            for (int i = 0; i < perceptronSimple.X.GetLength(0); i++)
            {
                string cadena = "";
                for (int j = 0; j < perceptronSimple.X.GetLength(1); j++)
                {
                    cadena += $"{perceptronSimple.X[i, j]} \t";
                }
                listEntradas.Items.Add(cadena);
            }

            for (int i = 0; i < perceptronSimple.Yd.GetLength(0); i++)
            {
                string cadena = "";
                for (int j = 0; j < perceptronSimple.Yd.GetLength(1); j++)
                {
                    cadena += $"{perceptronSimple.Yd[i, j]} \t";
                }
                listSalidas.Items.Add(cadena);
            }
        }

        private void cargarEntradasSalidasPatrones(int entradas, int salidas, int patrones)
        {
            lblEntras.Text = $"Entradas: {entradas}";
            lblSalidas.Text = $"Salidas: {salidas}";
            lblPatrones.Text = $"Patrones: {patrones}";
        }
    }
}
