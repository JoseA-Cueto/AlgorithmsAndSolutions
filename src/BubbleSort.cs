using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Array original:");
        PrintArray(array);

        Sort(array);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(array);
    }

    static void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Intercambia array[j] y array[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

