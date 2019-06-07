using System;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        FrmEntradasSalidas frmEntradasSalidas = new FrmEntradasSalidas();
        FrmConfiguracion frmConfiguracion = new FrmConfiguracion();
        FrmEntrenamiento frmEntrenamiento = new FrmEntrenamiento();
        PerceptronSimple perceptronSimple = new PerceptronSimple();

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormHija(frmEntradasSalidas);
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Parent = panelcontenedor;
            fh.Location = new Point((panelcontenedor.Width - fh.Width) / 2, (panelcontenedor.Height - fh.Height) / 2);
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }

        private void btnEntradasSalidas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(frmEntradasSalidas);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (frmEntradasSalidas.validarCampos())
            {
                AbrirFormHija(frmConfiguracion);
            }
        }

        private void btnEntrenamiento_Click(object sender, EventArgs e)
        {
            if (frmConfiguracion.validarCampos())
            {
                AbrirFormHija(frmEntrenamiento);

                perceptronSimple.X = frmEntradasSalidas.perceptronSimple.X;
                perceptronSimple.Yd = frmEntradasSalidas.perceptronSimple.Yd;
                perceptronSimple.Nombre = frmEntradasSalidas.perceptronSimple.Nombre;

                perceptronSimple.NumeroIteraciones= frmConfiguracion.perceptronSimple.NumeroIteraciones;
                perceptronSimple.RataAprendizaje = frmConfiguracion.perceptronSimple.RataAprendizaje;
                perceptronSimple.ErrorMaximo = frmConfiguracion.perceptronSimple.ErrorMaximo;

                frmEntrenamiento.setPerceptronSimple(perceptronSimple);
                frmEntrenamiento.perceptronSimple.formEntrenamiento = frmEntrenamiento;
                frmEntrenamiento.iniciarEntrenamiento();
            }

        }

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
