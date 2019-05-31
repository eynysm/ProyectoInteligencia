using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmEntradasSalidas());
		}

		private void AbrirFormHija(object formhija)
		{
			if (this.panelcontenedor.Controls.Count > 0)
				this.panelcontenedor.Controls.RemoveAt(0);
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
			AbrirFormHija(new FrmEntradasSalidas());
		}

		private void btnConfiguracion_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmConfiguracion());
		}

		private void btnEntrenamiento_Click(object sender, EventArgs e)
		{
			AbrirFormHija(new FrmEntrenamiento());
		}
	}
}
