using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class estudiante : miembroFac
    {
        private string curso;
        public estudiante(string curso, string nombre, string apellidos, int id,
            string estadoCivil, string tipo) : base(nombre, apellidos, id, estadoCivil, tipo)
        {
            this.curso = curso;
        }

        public void nuevoCurso(string curso)
        {
            this.curso = curso;
        }
        public override string ToString()
        {
            return "Curso: " + curso;
        }
    }
}
