using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FacultadPOO
{
    public class empleado : miembroFac
    {
        private DateTime fechaIncorp;
        private short numDespacho;
        public empleado(DateTime fechaIncorp, short numDespacho,
            string nombre, string apellidos, int id, string estadoCivil,
            string tipo) : base(nombre, apellidos, id, estadoCivil, tipo)
        {
            this.fechaIncorp = fechaIncorp;
            this.numDespacho = numDespacho;
        }

        public void reasignarDespacho(short numDespacho)
        {
            this.numDespacho = numDespacho;
        }
        public override string ToString()
        {
            return "Fecha de ingreso: " + fechaIncorp +
                "\nDespacho: " + numDespacho;
        }
    }
}