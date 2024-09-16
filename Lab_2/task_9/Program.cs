using System;

class Program
{
    static void Main()
    {
        // Введення розміру матриці
        Console.WriteLine("Введiть кiлькiсть рядкiв матрицi:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введiть кiлькiсть стовпцiв матрицi:");
        int cols = int.Parse(Console.ReadLine());

        // Створення та заповнення матриці
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        Console.WriteLine("Матриця:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-100, 100);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Обчислення суми елементів у рядках з від'ємними елементами
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            bool hasNegative = false;
            int rowSum = 0;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                }
                rowSum += matrix[i, j];
            }

            if (hasNegative)
            {
                sum += rowSum;
            }
        }

        Console.WriteLine("Сума елементiв у рядках, що мiстять хоча б один вiд'ємний елемент: " + sum);
        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}