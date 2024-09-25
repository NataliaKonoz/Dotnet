using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводимо рядок, який потрібно скопіювати
        Console.Write("Введiть рядок: ");
        string inputString = Console.ReadLine();

        // Вводимо довжину другого рядка
        Console.Write("Введiть довжину другого рядка: ");
        int desiredLength;

        // Перевірка правильності введення
        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length)
        {
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        // Обчислюємо позицію для вставлення
        int spacesBefore = (desiredLength - inputString.Length) / 2;

        // Створюємо рядок з нулями
        char[] resultArray = new string('0', desiredLength).ToCharArray();

        // Вставляємо текст першого рядка в центр другого, рахуючи з кінця
        for (int i = 0; i < inputString.Length; i++)
        {
            resultArray[desiredLength - 1 - (spacesBefore + i)] = inputString[i];
        }

        // Друкуємо результат
        Console.WriteLine("Результат: " + new string(resultArray));

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}