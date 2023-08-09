using System;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main()
        {
            int X = 50;
            int Y = 25;
            double N = 40.2;
            double M = 12.5;

            Console.WriteLine("X + Y = " + (X + Y));
            Console.WriteLine("X - Y = " + (X - Y));
            Console.WriteLine("X * Y = " + (X * Y));
            Console.WriteLine("X / Y = " + (X / Y));
            Console.WriteLine("X % Y = " + (X % Y));
            Console.WriteLine("M + N = " + (M + N));
            Console.WriteLine("M - N = " + (M - N));
            Console.WriteLine("M * N = " + (M * N));
            Console.WriteLine("M / N = " + (M / N));
            Console.WriteLine("M % N = " + (M % N));
            Console.WriteLine("Doble de X = " + (X*X));
            Console.WriteLine("Doble de Y = " + (Y * Y));
            Console.WriteLine("Doble de M = " + (M * M));
            Console.WriteLine("Doble de N = " + (N * N));
            Console.WriteLine("Suma de todas las variables = " + (X + Y + M + N));
            Console.WriteLine("Producto de todas las variables = " + (X - Y - M - N));
        }
    }
}
