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
    public partial class AltaChofer : ProyectoFinalFormulario.formulario.AltaEmpleado
    {
        public AltaChofer()
        {
            InitializeComponent();
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            string clave = this.txtClave.Text;
            string nombre = this.txtNombre.Text;
            int edad = int.Parse(this.txtEdad.Text);
            char licencia = char.Parse(this.cboLicencia.Text);

            Chofer objChofer = new Chofer(clave, nombre, edad, licencia);
            Datos.addEmpleado(objChofer);
            this.Close();
        }
    }
}
