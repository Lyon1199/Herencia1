using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadPila
{
    public class nodoPila
    {

        public static void imprimirPila(Stack pila)
        {
            if (pila == null) { Console.WriteLine("Primero crea la pila"); }
            else { Console.WriteLine("Elementos " + pila.ToString()); }
        }

        public static Stack pushPila(Stack pila)
        {
            if (pila == null) { Console.WriteLine("Primero crea la pila"); }
            else
            {
                Console.WriteLine("Ingrese el valor: ");
                String valor = Console.ReadLine();
                pila.Push(valor);
            }
            return pila;
        }
        public static Stack popPila(Stack pila)
        {
            if (pila == null) { Console.WriteLine("Primero crea la pila"); }
            else
            {
                Console.WriteLine("Pop a la pila: " + pila.Pop());
                Console.WriteLine("Sacaste un elemento.");

            }
            return pila;
        }
        public static Stack peekPila(Stack pila)
        {
            if (pila == null) { Console.WriteLine("Primero crea la pila"); }
            else
            {
                Console.WriteLine("Peek a la pila: " + pila.Peek());
            }
            return pila;
        }
    }
}

