using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalFormulario.clases
{
    static class Datos
    {
        private static Empleado[] empleados = new Empleado[10];
        private static int indice = 0;

        public static int Size
        {
            get { return indice; }
        }


        public static void addEmpleado(Empleado nuevoEmpleado)
        {
            if (indice < 10)
            {
                empleados[indice] = nuevoEmpleado;
                indice++;
            }
        }
        public static Empleado getEmpleado (int i)
        {
            if (i >= 0 && i <= 9)
                return empleados[i];
            else
                return null;
        }
    }
}
