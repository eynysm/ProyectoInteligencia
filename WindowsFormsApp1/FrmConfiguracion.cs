using System;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FrmConfiguracion : Form
    {
        public PerceptronSimple perceptronSimple { get; set; }
        public FrmConfiguracion()
        {
            InitializeComponent();
            perceptronSimple = new PerceptronSimple();
        }

        public bool validarCampos()
        {
            if (!string.IsNullOrEmpty(txtIteraciones.Text) && !string.IsNullOrEmpty(txtRata.Text) && !string.IsNullOrEmpty(txtErrorMaximo.Text))
            {
                perceptronSimple.NumeroIteraciones = Convert.ToInt32(txtIteraciones.Text);
                perceptronSimple.RataAprendizaje = (float)Convert.ToDouble(txtRata.Text);
                perceptronSimple.ErrorMaximo = (float)Convert.ToDouble(txtErrorMaximo.Text);

                return true;
            }
            MessageBox.Show("Campos Vacios");
            return false;
        }

        private void FrmConfiguracion_Load(object sender, System.EventArgs e)
        {

        }
    }
}
