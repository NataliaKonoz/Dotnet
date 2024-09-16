using System;

class Program
{
    static void Main()
    {
        // Зчитування розміру матриці з консолі
        Console.Write("Введiть розмiр матрицi: ");
        int size = int.Parse(Console.ReadLine());

        // Створення матриці заданого розміру
        int[,] matrix = new int[size, size];

        // Заповнюємо матрицю
        FillMatrix(matrix);

        // Виводимо матрицю
        PrintMatrix(matrix);
        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    static void FillMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        int value = 1;

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                // Перевірка для головної діагоналі та побічної діагоналі
                if (i == j || i + j == size - 1 || i < j && i + j < size - 1 || i > j && i + j > size - 1)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, j] = value++;
                }
            }
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