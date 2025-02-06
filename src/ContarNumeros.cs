using System;
using System.Text.RegularExpressions;

public class ContarNumeros
{
    public static void Ejecutar()
    {
        string text = "ufbsaubfa2176t467214haBFBA@@@";
        string pattern = @"[0-9]";
        var regex = new Regex(pattern);
        int cont = regex.Matches(text).Count;
        Console.WriteLine("cantidad: " + cont);
    }
}
