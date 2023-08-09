using System;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main()
        {
            int N = 20;
            double A = 5.89;
            char C = 'a';

            double suma = N + A;
            double resta = A - N;
            int valorNumerico = C;

            Console.WriteLine("Variable N: " + N);
            Console.WriteLine("Variable A: " + A);
            Console.WriteLine("Variable C: " + C);

            Console.WriteLine("{0}+{1}={2}", N, A, suma);
            Console.WriteLine("{0}-{1}={2}", A, N, resta);
            Console.WriteLine("Valor numérico del caracter " + C + " = " + valorNumerico);
        }
    }
}
