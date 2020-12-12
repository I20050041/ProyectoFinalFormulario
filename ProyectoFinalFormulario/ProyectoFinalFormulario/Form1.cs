using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalFormulario.formulario;

namespace ProyectoFinalFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProfesor formulario = new AltaProfesor();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaChofer formulario = new AltaChofer();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDatos formulario = new MostrarDatos();
            formulario.MdiParent = this;
            formulario.Show();
        }

       
    }
}
