using System;
using System.Collections.Generic; // Для використання List

class Program
{
    static void Main()
    {
        Console.Write("Введiть розмiр списку: ");
        int size = int.Parse(Console.ReadLine());
        List<int> list = new List<int>(size);
        Random rand = new Random();

        // Заповнення списку випадковими значеннями від -100 до 100
        for (int i = 0; i < size; i++)
        {
            list.Add(rand.Next(-100, 101));
        }

        Console.WriteLine("\nПочатковий список:");
        PrintListWithColors(list);

        List<int> result = new List<int>(size);
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        List<int> zeros = new List<int>();

        // Сортування елементів у різні списки
        foreach (int num in list)
        {
            if (num > 0)
            {
                positive.Add(num);
            }
            else if (num < 0)
            {
                negative.Add(num);
            }
            else
            {
                zeros.Add(num);
            }
        }

        // Об'єднання списків у результат
        result.AddRange(positive);
        result.AddRange(zeros);
        result.AddRange(negative);

        Console.WriteLine("\nСписок пiсля сортування:");
        PrintListWithColors(result);

        Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    // Функція для виведення списку з кольоровим виділенням
    static void PrintListWithColors(List<int> list)
    {
        foreach (int num in list)
        {
            if (num > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green; // Додатні числа зеленим кольором
            }
            else if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;   // Від'ємні числа червоним кольором
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Нулі жовтим кольором
            }
            Console.Write(num + " ");
        }
        Console.ResetColor(); // Повернути стандартний колір після виведення
        Console.WriteLine();
    }
}