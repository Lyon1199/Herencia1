using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class miembroFac
    {
        private string nombres, apellidos, estadoCivil, tipo;
        private int id;

        public miembroFac(string nombre, string apellidos, int id, string estadoCivil, string tipo)
        {
            this.nombres = nombre;
            this.apellidos = apellidos;
            this.id = id;
            this.estadoCivil = estadoCivil;
            this.tipo = tipo;
        }

        public void cambioEstadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }

        public void imprimirMiembro()
        {
            Console.WriteLine("Nombre: " + nombres
                + "\nApellidos: " + apellidos
                + "\nID: " + id
                + "\nEstado Civil: " + estadoCivil
                + "\nTipo: " + tipo);
        }
    }
}
