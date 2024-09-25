using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок: ");                       // Вводимо рядок, який потрібно скопіювати
        string inputString = Console.ReadLine();

        Console.Write("Введiть довжину другого рядка: ");       // Вводимо довжину другого рядка
        int desiredLength;

        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length) 
        {        // Перевірка правильності введення
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        int repeatableCharCount = 0;                            // Обчислюємо кількість символів для повторення (без '?')
        foreach (char c in inputString)
        {
            if (c != '?') repeatableCharCount++;
        }

        int actualLength = inputString.Length + repeatableCharCount;                    // Обчислюємо необхідну довжину результату
        actualLength = Math.Min(desiredLength, actualLength);                           // Якщо результат не може вміститися у задану довжину, обмежуємо
        int spacesBefore = (desiredLength - actualLength) / 2;                          // Обчислюємо позицію для вставлення
        char[] resultArray = new string('0', desiredLength).ToCharArray();              // Створюємо рядок з нулями
        int resultIndex = spacesBefore;
                                                                                        // Вставляємо текст першого рядка в центр другого, повторюючи кожен символ, окрім '?'
        for (int i = 0; i < inputString.Length && resultIndex < desiredLength; i++) 
        {
            resultArray[resultIndex++] = inputString[i];
            if (inputString[i] != '?' && resultIndex < desiredLength) 
            {
                resultArray[resultIndex++] = inputString[i];                            // Повторення символу
            }
        }
        
        Console.WriteLine("Результат: " + new string(resultArray));
        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}