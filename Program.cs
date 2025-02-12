using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecciona el ejercicio a ejecutar:");
        Console.WriteLine("1. Invertir Cadena");
        Console.WriteLine("2. Contar Caracteres");
        Console.WriteLine("3. Distancia de Hamming");
        Console.WriteLine("4. Contador de Palabras");
        Console.WriteLine("5. Contar Numeros");
        Console.WriteLine("6. Check Prime Number");
        Console.WriteLine("7. Bubble Sort");
        Console.WriteLine("8. Factorial");
        Console.WriteLine("9. FibonacciSequence");

        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                InvertString.Ejecutar();
                break;
            case 2:
                CountCharacterOccurrences.Ejecutar();
                break;
            case 3:
                HammingDistance.Ejecutar();
                break;
            case 4:
                WordCounter.Ejecutar();
                break;
            case 5:
                CountNumbers.Ejecutar();
                break;
            case 6:
                PrimeNumbers.Execute();
                break;
            case 7:
                BubbleSort.Execute();
                break;
            case 8:
                Factorial.Execute();
                break;
            case 9:
                FibonacciSequence.Execute();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

      
        Console.WriteLine("Press any key to close...");
        Console.ReadLine();
    }
}










