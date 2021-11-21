using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Empresa_POO
{
    public class Employer
    {
        private string apellidos, nombres, departamento;
        private short edad;

        public Employer(string nombres, string apellidos, string departamento, short edad)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.departamento = departamento;
            this.edad = edad;
        }

        public string getNombres() { return nombres; }
        public void setNombres(string nombres) { this.nombres = nombres; }
        public string getApellidos() { return apellidos; }
        public void setApellidos(string apellidos) { this.apellidos = apellidos; }
        public string getDepartamento() { return departamento; }
        public void setDepartamento(string departamento) { this.departamento = departamento; }
        public int getEdad() { return edad; }
        public void setEdad(short edad) { this.edad = edad; }


    }
}
