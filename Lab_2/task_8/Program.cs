using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть розмiр матрицi: ");
        int size = int.Parse(Console.ReadLine());

        // Створення динамічної зубчастої матриці заданого розміру
        int[][] matrix = new int[size][];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
        }

        // Заповнюємо матрицю
        FillMatrix(matrix);

        // Виводимо матрицю
        PrintMatrix(matrix);
        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    static void FillMatrix(int[][] matrix)
    {
        int size = matrix.Length;
        int value = 1;

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                // Перевірка для головної діагоналі та побічної діагоналі
                if (i == j || i + j == size - 1 || i < j && i + j < size - 1 || i > j && i + j > size - 1)
                {
                    matrix[i][j] = 0;
                }
                else
                {
                    matrix[i][j] = value++;
                }
            }
        }
    }

    static void PrintMatrix(int[][] matrix)
    {
        int size = matrix.Length;
        int maxNumberLength = (matrix[size - 1][size - 1] + 1).ToString().Length;
        int padding = maxNumberLength + 2; // Додаємо додаткові пробіли для кращої читабельності

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (matrix[i][j] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Числа 0 червоним кольором
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Числа більше 0 зеленим кольором
                }
                Console.Write(matrix[i][j].ToString().PadLeft(padding));
            }
            Console.WriteLine();
            Console.ResetColor(); // Скидаємо колір для наступного рядка
        }
    }
}