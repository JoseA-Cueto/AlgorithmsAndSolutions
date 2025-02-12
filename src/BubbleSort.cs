using System;

public class BubbleSort
{
    public static void Execute()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Array original:");
        PrintArray(array);

        Sort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }

    public static void Sort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Intercambia array[j] y array[j+1]
                    (array[j], array[j + 1]) = (array[j + 1], array[j]); // Swap en una línea
                    swapped = true;
                }
            }

            // Si no hubo intercambios en la pasada actual, terminamos antes
            if (!swapped) break;
        }
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}



