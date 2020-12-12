using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoFinalFormulario.clases;

namespace ProyectoFinalFormulario.formulario
{
    public partial class AltaProfesor : ProyectoFinalFormulario.formulario.AltaEmpleado
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            string clave = this.txtClave.Text;
            string nombre = this.txtNombre.Text;
            int edad = int.Parse(this.txtEdad.Text);
            string escolaridad = this.txtEscolaridad.Text;

            Profesor objProfesor = new Profesor(clave, nombre, edad, escolaridad);
            Datos.addEmpleado(objProfesor);
            this.Close();

        }
    }
}
