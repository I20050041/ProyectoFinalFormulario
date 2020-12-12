using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFormulario.clases
{
    class Profesor : Empleado
    {
        private string escolaridad;

        public string Escolaridad
        {
            get { return escolaridad; }
            set { escolaridad = value; }
        }
        public Profesor (string claveProfesor,string nombreProfesor,int edadProfesor,string escolaridadProfesor) :base (claveProfesor,nombreProfesor,edadProfesor)
        {
            this.Escolaridad = escolaridadProfesor;
        }
        public override string ToString()
        {
            return "Escolaridad = " + Escolaridad;
        }

    }
}
