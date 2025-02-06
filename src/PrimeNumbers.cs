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
      
        if (number <= 1) return false;

       
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

    
        return true;
    }
}
