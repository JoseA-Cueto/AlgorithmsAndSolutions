using System;
using System.Linq;

public class CountNumbers
{
    public static void Ejecutar()
    {
        string text = "ufbsaubfa2176t467214haBFBA@@@";

        int count = text.Count(char.IsDigit);

        Console.WriteLine("Cantidad: " + count);
    }
}

