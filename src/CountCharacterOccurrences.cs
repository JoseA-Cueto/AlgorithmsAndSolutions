using System;
using System.Linq;

public class CountCharacterOccurrences
{
    public static void Ejecutar()
    {
        string text = "kbhafbsagfsanfiusafnsahfysanajfa7sf8qwr9rwuahfiaifasjaqijo";
        char character = 'f';

       
        int count = text.Count(c => c == character);

        Console.WriteLine($"Se repite la letra '{character}' {count} veces");
    }
}


