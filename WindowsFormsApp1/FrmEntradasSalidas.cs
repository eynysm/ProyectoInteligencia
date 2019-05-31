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
	public partial class FrmEntradasSalidas : Form
	{
		public FrmEntradasSalidas()
		{
			InitializeComponent();
		}

		private void FrmEntradasSalidas_Load(object sender, EventArgs e)
		{

		}

		public bool validarCampos()
		{
			if (!string.IsNullOrEmpty(txtNombre.Text))
			{

				return true;
			}
			MessageBox.Show("Hay campos vacios");
			return false;
		}

		private void btnEntradasSalidas_Click(object sender, EventArgs e)
		{

		}
	}
}
