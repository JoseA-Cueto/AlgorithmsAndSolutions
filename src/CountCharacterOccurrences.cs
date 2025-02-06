using System;
using System.Linq;

public class CountCharacterOccurrences
{
    public static void Ejecutar()
    {
        string text = "kbhafbsagfsanfiusafnsahfysanajfa7sf8qwr9rwuahfiaifasjaqijo";
        char character = 'f';
        int cont = 0;

        foreach (char c in text)
        {
            if (c == character)
            {
                cont++;
            }
        }

        cont = text.Where(c => c == character).Count();
        Console.WriteLine($"Se repite la letra {character} {cont} veces");
    }
}

