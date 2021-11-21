using System;
using System.Collections.Generic;
using System.Text;

namespace TadCola
{

    class Cola
    {
        Nodo Primero = new Nodo();
        Nodo Ultimo = new Nodo();

        //primero = null    ultimo = null     nuevo = 23           23, 56, 78, 12, 67

        // cola --                    23 

        public Cola()
        {
            Primero = null;
        }
        public void insertarNodo()
        {

            Nodo Nuevo = new Nodo();
            Console.Write("el dato que contendra el nuevo nodo:");
            Nuevo.Dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

            Console.WriteLine("\n Nodo Ingresado\n");


        }
        public void desplegarcola()

        {


            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("" + Actual.Dato);
                    Actual = Actual.Siguiente;
                }

            }
            else
            {

                Console.WriteLine(" la cola se encuentra vacia");
            }
        }
    }
}

