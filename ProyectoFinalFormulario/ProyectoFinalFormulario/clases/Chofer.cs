using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFormulario.clases
{
    class Chofer : Empleado
    {
        private char licencia;

        public char Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }
        public Chofer(string claveChofer, string nombreChofer, int edadChofer, char licenciaChofer) : base(claveChofer, nombreChofer, edadChofer)
        {
            this.Licencia = licenciaChofer;
        }
        public override string ToString()
        {
            return "Licencia = " + Licencia;
        }
    }
}
