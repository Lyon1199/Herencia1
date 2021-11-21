using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_POO
{
    public class employeFijo : Employer
    {
        private double baseAnual, sueldo;
        private short aniosServicio;
        public employeFijo(short aniosServicio, double baseAnual,
            string nombres, string apellidos, string departamento,
            short edad) : base(nombres, apellidos, departamento, edad)
        {
            this.aniosServicio = aniosServicio;
            this.baseAnual = baseAnual;
        }

        public void setSueldo(double sueldo, short aniosServicio, double baseAnual)
        {
            this.sueldo = sueldo;
            this.aniosServicio = aniosServicio;
            this.baseAnual = baseAnual;
            sueldo = sueldo + (aniosServicio * baseAnual);
        }
        public double getSueldo()
        {
            return sueldo;
        }
    }
}

