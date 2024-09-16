using System;
class Program
{
    static void Main()
    {
        int[] array = new int[100];
        Random rand = new Random();

        // Заповнення масиву випадковими значеннями від -100 до 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101);
        }

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

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
        PrintArray(result);

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}