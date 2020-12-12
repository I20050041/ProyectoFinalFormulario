using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFormulario.clases
{
    class Empleado 
    {
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set {
                if (value > 0 && value <= 100)
                    edad = value;
                else
                    edad = 0;
            }
        }
        public Empleado(string claveEmpleado,string nombreEmpleado,int edadEmpleado)
        {
            this.Clave = claveEmpleado;
            this.Nombre = nombreEmpleado;
            this.Edad = edadEmpleado;
        }


    }
}
