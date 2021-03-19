using System;

namespace Ejercicio_Y
{
    class Program
    {

        public static string GeneraLetra(int rango1, int rango2)
        {
            rango1 = 64;
            rango2 = 123;
            Random ran = new Random();
            int numero = Convert.ToInt32(ran.Next(rango1,rango2));
            string respuesta = "";

            if (((numero > rango1) & (numero < rango2)))
            {
                respuesta = Convert.ToString((char)numero);
            }
            return respuesta;
        } 


        static void Main(string[] args)
        {
            byte CAN, contador;
            //en el video se me olvido explicar que el contador practicamente va aumentando hasta que se cumple la cantidad dada de numeros que el usuario da, CAN es la cantidad dada
            string linea;
            Console.Write("Cuantos Numeros: ");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            string letras = "";
            for (contador = 1; contador <= CAN; contador++)
            {
                letras = GeneraLetra(64, 123);
                Console.WriteLine($"El codigo de {letras}");
            }
        }
    }
}
