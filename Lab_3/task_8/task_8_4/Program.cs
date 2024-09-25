using System;
using System.IO;
class Program
{
    static void Main(string[] args) {
        Console.Write("Введiть рядок: ");             
        string inputString = Console.ReadLine();

        Console.Write("Введiть довжину другого рядка: ");
        int desiredLength;

        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length) {        // Перевірка правильності введення
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        int repeatableCharCount = 0;                            // Обчислюємо кількість символів для повторення (без '?')
        foreach (char c in inputString) {
            if (c != '?') repeatableCharCount++;
        }

        int actualLength = inputString.Length + repeatableCharCount;                    // Необхідна довжину результату
        actualLength = Math.Min(desiredLength, actualLength);                           // Якщо результат не може вміститися у задану довжину, обмежуємо
        int spacesBefore = (desiredLength - actualLength) / 2;                          // Позиція для вставлення
        char[] resultArray = new string('0', desiredLength).ToCharArray();
        int resultIndex = spacesBefore;

        for (int i = 0; i < inputString.Length && resultIndex < desiredLength; i++) {    // Вставляємо текст першого рядка в центр другого, повторюючи кожен символ, окрім '?'
            resultArray[resultIndex++] = inputString[i];
            if (inputString[i] != '?' && resultIndex < desiredLength) {
                resultArray[resultIndex++] = inputString[i];                             // Повторення символу
            }
        }

        string binaryFilePath = "../output.bin";
        using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create))) {
            writer.Write(resultArray);
        }

        Console.WriteLine("Вмiст двiйкового файлу:");
        using (BinaryReader reader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open))) {
            char[] readResultArray = reader.ReadChars(desiredLength);
            Console.WriteLine("Результат: " + new string(readResultArray));
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}