using System;

public class FibonacciSequence
{
    public static void Execute()
    {
        Console.Write("Enter the number of Fibonacci terms to generate: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"First {n} Fibonacci numbers:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.WriteLine();
    }

    // Método para calcular el enésimo número de Fibonacci
    private static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}

