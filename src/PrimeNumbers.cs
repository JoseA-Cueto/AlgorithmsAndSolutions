using System;

public class PrimeNumbers
{
    public static void Execute()
    {
        
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

       
        Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime.");
    }


    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true; // 2 es el único primo par
        if (number % 2 == 0) return false; // Si es par y no es 2, no es primo

        for (int i = 3; i <= Math.Sqrt(number); i += 2) 
        {
            if (number % i == 0) return false;
        }

        return true;
    }

}
