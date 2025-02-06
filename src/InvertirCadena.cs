using System;

public class InvertirCadena
{
    public static void Ejecutar()
    {
        string text = "Willy";
        string textResult = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            textResult += text[i];
        }

        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        textResult = new string(chars);

        Console.WriteLine(textResult);
    }
}
