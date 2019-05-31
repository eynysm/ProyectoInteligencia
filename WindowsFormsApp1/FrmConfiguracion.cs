using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FrmConfiguracion : Form
	{
		public FrmConfiguracion()
		{
			InitializeComponent();
		}

		public bool validarCampos()
		{
			if (!string.IsNullOrEmpty(txtIteraciones.Text) && !string.IsNullOrEmpty(txtRata.Text) && !string.IsNullOrEmpty(txtErrorMaximo.Text))
			{
				return true;
			}
			MessageBox.Show("Campos Vacios");
			return false;
		}
	}
}
