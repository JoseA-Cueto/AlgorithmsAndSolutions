using System;
using System.Linq;

public class HammingDistance
{
    public static void Ejecutar()
    {
        string text1 = "patoasd";
        string text2 = "litoasf";

        if (text1.Length != text2.Length)
        {
            throw new ArgumentException("Las cadenas deben tener la misma longitud.");
        }

        int distancia = text1.Zip(text2, (c1, c2) => c1 != c2 ? 1 : 0).Sum();

        Console.WriteLine($"Distancia de Hamming: {distancia}");
    }
}

