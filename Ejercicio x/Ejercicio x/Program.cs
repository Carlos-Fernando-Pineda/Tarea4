using System;
using System.Threading;

namespace Ejercicio_x
{
    class Program
    {

        public static string Mid(string parametro, int StartIndex, int length)
        {
            string result = parametro.Substring(StartIndex, length);
            return result;
        }

        public static void marque(string nombre)
        {
            string final;
            int grua = 0;
            int finalpos = 0;
            int inicial1 = 0;
            int inicial2 = 0;
            
            Console.SetCursorPosition(1, 5);
            Console.Write(nombre);
            inicial1 = nombre.Length;
            inicial2 = 50;
            nombre = nombre.ToUpper();

            for (finalpos = nombre.Length; finalpos >= 1; finalpos--)
            {
                final = Mid(nombre, finalpos - 1, 1);
                for (grua = inicial1; grua <= inicial2; grua++)
                {
                    Console.SetCursorPosition(grua, 5);
                    Console.Write("-" + final);
                    Thread.Sleep(10);
                }
                inicial2 = inicial2 - 1;
                inicial1 = inicial1 - 1;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            marque(nombre);
            marque("juan");


        }
    }
}
