using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок: ");
        string inputString = Console.ReadLine();
        inputString = inputString.Replace("к", "");
        Console.Write("Введiть довжину другого рядка: ");
        int desiredLength;

        // Перевірка правильності введення
        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length)
        {
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        int spacesBefore = (desiredLength - inputString.Length) / 2;
        char[] resultArray = new string('0', desiredLength).ToCharArray();

        // Вставляємо текст першого рядка в центр другого, рахуючи з кінця
        for (int i = 0; i < inputString.Length; i++)
        {
            resultArray[desiredLength - 1 - (spacesBefore + i)] = inputString[i];
        }

        Console.WriteLine("Результат: " + new string(resultArray));

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}