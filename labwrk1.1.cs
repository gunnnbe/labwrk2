using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array (N):");
        int N;

        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        int[] array = GenerateRandomArray(N);

        Console.WriteLine("\nOriginal array:");
        PrintArray(array);

        int productOfEvenIndexes = CalculateProductOfEvenIndexes(array);
        Console.WriteLine($"\nProduct of elements with even indexes: {productOfEvenIndexes}");

        int sumBetweenZeros = CalculateSumBetweenZeros(array);
        Console.WriteLine($"Sum of elements between the first and last zeros: {sumBetweenZeros}");

        TransformArray(array);

        Console.WriteLine("\nTransformed array:");
        PrintArray(array);
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(-10, 11); // Random numbers from -10 to 10
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int CalculateProductOfEvenIndexes(int[] array)
    {
        int product = 1;

        for (int i = 0; i < array.Length; i += 2)
        {
            product *= array[i];
        }

        return product;
    }

    static int CalculateSumBetweenZeros(int[] array)
    {
        int firstZeroIndex = Array.IndexOf(array, 0);
        int lastZeroIndex = Array.LastIndexOf(array, 0);

        if (firstZeroIndex == -1 || lastZeroIndex == -1 || firstZeroIndex == lastZeroIndex)
        {
            return 0;
        }

        int sum = 0;

        for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static void TransformArray(int[] array)
    {
        int[] positiveElements = array.Where(element => element >= 0).ToArray();
        int[] negativeElements = array.Where(element => element < 0).ToArray();

        positiveElements.CopyTo(array, 0);
        negativeElements.CopyTo(array, positiveElements.Length);
    }
}
