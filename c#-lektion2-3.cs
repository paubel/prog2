using System;
using System.Collections.Generic;

class Program
{
    // Linjär sökning
    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i;
        }
        return -1;
    }

    // Binär sökning (kräver sorterad array)
    static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    // Bubble sort – egen sortering
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Linjär sökning ===");
        int[] numbers = { 3, 5, 7, 9 };
        int indexLinear = LinearSearch(numbers, 7);
        Console.WriteLine($"Siffran 7 hittades på index: {indexLinear}");

        Console.WriteLine("\n=== Binär sökning (kräver sortering) ===");
        int[] sortedArray = { 2, 4, 6, 8, 10 };
        int indexBinary = BinarySearch(sortedArray, 8);
        Console.WriteLine($"Siffran 8 hittades på index: {indexBinary}");

        Console.WriteLine("\n=== Inbyggd sortering av array ===");
        int[] unsortedArray = { 4, 2, 9, 1 };
        Array.Sort(unsortedArray);
        Console.WriteLine("Sorterad array: " + string.Join(", ", unsortedArray));

        Console.WriteLine("\n=== Inbyggd sortering av List<string> ===");
        List<string> names = new List<string> { "Anna", "Zara", "Bo" };
        names.Sort();
        Console.WriteLine("Sorterade namn: " + string.Join(", ", names));

        Console.WriteLine("\n=== Bubble sort (egen sorteringsalgoritm) ===");
        int[] arr = { 9, 3, 7, 1 };
        BubbleSort(arr);
        Console.WriteLine("BubbleSort resultat: " + string.Join(", ", arr));
    }
}
