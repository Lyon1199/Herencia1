using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_POO
{
    public class employerPerHoras : Employer
    {
        private static double precioPerHour;
        private double sueldo;
        private int horasTrabajadas;

        public employerPerHoras(double precioPerHour, int horasTrabajadas,
            string nombres, string apellidos, string departamento,
            short edad) : base(nombres, apellidos, departamento, edad)
        {
            this.horasTrabajadas = horasTrabajadas;
        }

        public void setSueldo(double sueldo, double precioPerHour, int horasTrabajadas)
        {
            this.sueldo = sueldo;
            this.horasTrabajadas = horasTrabajadas;
            sueldo = precioPerHour * horasTrabajadas;
        }
        public double getSueldo()
        {
            return sueldo;
        }
    }
}
