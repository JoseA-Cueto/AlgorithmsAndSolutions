using System;
using System.Text.RegularExpressions;

public class WordCounter
{
    public static void Ejecutar()
    {
        string text = "                 aca hay            varias      palabras               ";
        int n = 0;
        text = Regex.Replace(text, @"\s+", " ").Trim();
        var words = text.Split(' ');
        n = words.Length;
        Console.WriteLine(n);
    }
}
