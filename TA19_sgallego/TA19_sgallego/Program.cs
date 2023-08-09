using System;

namespace Ejercicio1{
    class Ejercicio1
    {
        static void Main()
        {
            int num1 = 10;
            int num2 = 5;

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine("Numero 1: {0} | Numero 2: {1}", num1, num2);
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicacion: " + multiplicacion);
            Console.WriteLine("Division: " + division);
        }
    }
}
