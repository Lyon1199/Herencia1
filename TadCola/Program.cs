using System;

namespace TadCola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            c.insertarNodo();
            Console.WriteLine(" cola ingresada");
            c.desplegarcola();
        }
    }
}
