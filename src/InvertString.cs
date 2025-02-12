using System;

public class InvertString
{
    public static void Ejecutar()
    {
        string text = "Willy";

        
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);  

      
        string textResult = new string(chars);

       
        Console.WriteLine(textResult);
    }
}

