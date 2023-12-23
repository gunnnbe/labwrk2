using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows in the matrix:");
        int rows;

        while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        Console.WriteLine("Enter the number of columns in the matrix:");
        int columns;

        while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        int[,] matrix = GenerateRandomMatrix(rows, columns);

        Console.WriteLine("\nOriginal matrix:");
        PrintMatrix(matrix);

        int columnsWithZeros = CountColumnsWithZeros(matrix);
        Console.WriteLine($"\nColumns with at least one zero: {columnsWithZeros}");

        int longestSeriesRow = FindLongestSeriesRow(matrix);
        Console.WriteLine($"Row with the longest series of identical elements: {longestSeriesRow}");
    }

    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(0, 2); // Random numbers 0 or 1
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int CountColumnsWithZeros(int[,] matrix)
    {
        int columns = matrix.GetLength(1);
        int count = 0;

        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }

        return count;
    }

    static int FindLongestSeriesRow(int[,] matrix)
    {
        int longestSeriesRow = 0;
        int maxLength = 0;
        int currentLength = 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == matrix[i, j - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        longestSeriesRow = i;
                    }
                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestSeriesRow = i;
            }

            currentLength = 1;
        }

        return longestSeriesRow;
    }
}
