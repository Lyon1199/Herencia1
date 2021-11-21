using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class personalServicio : miembroFac
    {
        private string seccion;
        public personalServicio(string seccion, string nombre, string apellidos, int id,
            string estadoCivil, string tipo) : base(nombre, apellidos, id, estadoCivil, tipo)
        {
            this.seccion = seccion;
        }

        public void cambioSeccion(string seccion)
        {
            this.seccion = seccion;
        }
        public override string ToString()
        {
            return "Seccion " + seccion;
        }
    }
}
