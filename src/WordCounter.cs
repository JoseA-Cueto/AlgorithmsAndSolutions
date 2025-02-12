using System;

public class WordCounter
{
    public static void Ejecutar()
    {
        string text = "                 aca hay            varias      palabras               ";

        int count = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine(count);
    }
}

