using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class profesor : miembroFac
    {
        private string departamento;
        public profesor(string departamento, string nombre, string apellidos, int id,
            string estadoCivil, string tipo) : base(nombre, apellidos, id, estadoCivil, tipo)
        {
            this.departamento = departamento;
        }

        public void cambioDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
        public override string ToString()
        {
            return "Departamento " + departamento;
        }
    }
}

