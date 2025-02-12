using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Factorial
    {
        public static void Execute()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of " + num + " is " + FactorialRecursive(num));
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 0) return 1;
            return n * FactorialRecursive(n - 1);
        }
    }

