using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_POO
{
    public class EmployerTemp : Employer
    {
        private double sueldo;
        private DateTime entrada, salida;

        public EmployerTemp(DateTime entrada, DateTime salida,
            string nombres, string apellidos, string departamento,
            short edad) : base(nombres, apellidos, departamento, edad)
        {
            this.entrada = entrada;
            this.salida = salida;
        }

        public void setSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public double getSueldo()
        {
            return sueldo;
        }
    }
}