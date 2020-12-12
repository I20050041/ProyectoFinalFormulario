using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalFormulario.clases;

namespace ProyectoFinalFormulario.formulario
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Datos.Size; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = Datos.getEmpleado(i).Clave;
                dataGridView1[1, i].Value = Datos.getEmpleado(i).Nombre;
                dataGridView1[2, i].Value = Datos.getEmpleado(i).Edad;
                dataGridView1[3, i].Value = Datos.getEmpleado(i).ToString();


            }
        }
    }
}
