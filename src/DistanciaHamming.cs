using System;

public class DistanciaHamming
{
    public static void Ejecutar()
    {
        string text1 = "patoasd";
        string text2 = "litoasf";
        int longitud = 0;

        if (text1.Length != text2.Length)
        {
            throw new Exception("No son iguales las cadenas");
        }

        for (int i = 0; i < text1.Length; i++)
        {
            if (text1[i] != text2[i])
            {
                longitud++;
            }
        }

        Console.WriteLine(longitud);
    }
}
