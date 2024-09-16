using System;

class Program
{
    static void Main()
    {
        int size = 9;
        int[,] matrix = new int[size, size];

        // Значення для кожного стовпця
        int[] columnValues = new int[]
        {
            1, 8, 13, 16, 17, 18, 21, 26
        };

        // Заповнюємо стовпці
        FillColumn(matrix, 0, 1, 7, columnValues[0]);
        FillColumn(matrix, 1, 2, 6, columnValues[1]);
        FillColumn(matrix, 2, 3, 5, columnValues[2]);

        // Заповнюємо окремі елементи
        matrix[4, 3] = columnValues[3];
        matrix[4, 5] = columnValues[4];

        FillColumn(matrix, 6, 3, 5, columnValues[5]);
        FillColumn(matrix, 7, 2, 6, columnValues[6]);
        FillColumn(matrix, 8, 1, 7, columnValues[7]);

        // Виводимо матрицю
        PrintMatrix(matrix);

        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    static void FillColumn(int[,] matrix, int column, int startRow, int endRow, int startValue)
    {
        for (int i = startRow; i <= endRow; i++)
        {
            matrix[i, column] = startValue++;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}