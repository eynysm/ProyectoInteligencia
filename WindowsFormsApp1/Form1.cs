using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, IEjemplo
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void actulizarProgres(int i)
        {
            progressBar1.Value=i;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ejemplo ejemplo = new Ejemplo(this);
            ejemplo.entrenar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

     class Ejemplo
    {
        private IEjemplo ejemplo;

        public Ejemplo()
        {
        }

        public Ejemplo(IEjemplo ejemplo)
        {
            this.ejemplo = ejemplo;
        }

        internal void entrenar()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                ejemplo.actulizarProgres(i);
            }
        }
    }

    internal interface IEjemplo
    {
         void actulizarProgres(int i);
    }
}
