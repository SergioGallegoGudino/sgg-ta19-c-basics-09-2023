class Ejercicio5
{
    static void Main()
    {
        int A = 5;
        int B = 10;
        int C = 3;
        int D = 9;

        B = C;
        C = A;
        A = D;
        D = B;

        Console.WriteLine("Resultado: {0},{1},{2},{3}", A, B, C, D);

    }
}
