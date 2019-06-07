using System;
using System.IO;
using System.Windows.Forms;
using Logica;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
	public partial class FrmPatrones : Form
	{
		public PerceptronSimple perceptronSimple { get; set; }

		public FrmPatrones()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cargarEnntrenamiento();
		}

		private void cargarEnntrenamiento()
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
					cargarTablas();
					btnSimulacion.Enabled = true;
				}
				catch (IOException)
				{
				}
			}


		}

		private void cargarTablas()
		{
			string cadena = "";
			for (int i = 0; i < perceptronSimple.X.GetLength(0); i++)
			{
				for (int j = 0; j < perceptronSimple.X.GetLength(1); j++)
				{
					cadena += perceptronSimple.X[i, j];
				}
				for (int j = 0; j < perceptronSimple.Yd.GetLength(1); j++)
				{
					cadena += perceptronSimple.Yd[i, j];
				}
				listPatrones.Text += cadena + "\n";
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
