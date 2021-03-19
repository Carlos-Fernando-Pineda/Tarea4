using System;
using System.Threading;

namespace Tarea_3
{
    class Program
    {

        public static void dibuja(int Cantidad)
        {
            int altura = 22;
            int ancho = 44;
            int pos_vert1 = 5;
            int pos_horiz2 = 5;
            int pos_horiz1, pos_vert2, tik;

            for ( tik=1; tik <= Cantidad; tik++)
            {
                for (pos_horiz1 = pos_horiz2; pos_horiz1 <= ancho; pos_horiz1++)
                {
                    Console.SetCursorPosition(pos_horiz1, altura); Console.Write("?");
                    Console.SetCursorPosition(pos_horiz1, pos_vert1);Console.Write("?");
                }
                for (pos_vert2 = pos_vert1; pos_vert2 <= altura; pos_vert2++)
                {
                    Console.SetCursorPosition(pos_horiz2, pos_vert2);Console.Write("X");
                    Console.SetCursorPosition(ancho, pos_vert2);Console.Write("X");
                }
                pos_vert1 = pos_vert1 + 1;
                altura = altura - 1;
                pos_horiz2 = pos_horiz2 + 1;
                ancho = ancho - 1;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for (int rep = 1; rep < 9; rep++)
            {
                dibuja(rep);
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(25, 24);
            Console.WriteLine("Pulse una tecla");
        }
    }
}
