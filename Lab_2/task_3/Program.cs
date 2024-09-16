using System;
class Program
{
    static void Main()
    {
        Console.Write("Введiть розмiр масиву: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Random rand = new Random();

        // Заповнення масиву випадковими значеннями від -100 до 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101);
        }

        Console.WriteLine("\nПочатковий масив:");
        PrintArrayWithColors(array);
        int[] result = new int[array.Length];
        int posIndex = 0;
        int zeroIndex = 0;
        int negIndex = array.Length - 1;

        // Сортування елементів в новий масив
        foreach (int num in array)
        {
            if (num > 0)
            {
                result[posIndex++] = num;
            }
            else if (num < 0)
            {
                result[negIndex--] = num;
            }
        }

        // Встановлення нулів між додатними і від'ємними числами
        for (int i = posIndex; i <= negIndex; i++)
        {
            result[i] = 0;
        }

        Console.WriteLine("\nМасив пiсля сортування:");
        PrintArrayWithColors(result);

        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    // Функція для виведення масиву з кольоровим виділенням
    static void PrintArrayWithColors(int[] array)
    {
        foreach (int num in array)
        {
            if (num > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;   
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(num + " ");
        }
        Console.ResetColor(); // Повернути стандартний колір після виведення
        Console.WriteLine();
    }
}