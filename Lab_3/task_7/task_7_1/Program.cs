using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "../input.txt";   // Файл з початковим рядком і довжиною
        string outputFilePath = "../output.txt"; // Файл для результату

        if (!File.Exists(inputFilePath)) {                  // Перевіряємо, чи існує файл для зчитування
            Console.WriteLine($"Файл {inputFilePath} не знайдено. Створіть файл і введіть дані для обробки.");
            return;
        }

        string[] lines = File.ReadAllLines(inputFilePath);           // Зчитуємо рядки з файлу

        if (lines.Length < 2){              // Перевіряємо, чи є в файлі достатньо рядків (текст + довжина)
            Console.WriteLine("Файл має містити щонайменше два рядки: текст і довжину другого рядка.");
            return;
        }

        string inputString = lines[0].Trim();                   // Зчитуємо текстовий рядок
        Console.WriteLine("Введений рядок з файлу: " + inputString);

        int desiredLength;
        if (!int.TryParse(lines[1].Trim(), out desiredLength) || desiredLength < inputString.Length) {           // Зчитуємо довжину другого рядка
            Console.WriteLine("Некоректна довжина у файлі. Введіть довжину, що бiльша або рiвна довжинi першого рядка.");
            return;
        }

        Console.WriteLine("Довжина другого рядка з файлу: " + desiredLength);
        int spacesBefore = (desiredLength - inputString.Length) / 2;                    // Обчислюємо відстань для центрування
        char[] resultArray = new string('0', desiredLength).ToCharArray();              // Створюємо рядок з нулями

        for (int i = 0; i < inputString.Length; i++) {                                  // Вставляємо текст першого рядка в центр другого
            resultArray[spacesBefore + i] = inputString[i];
        }

        string result = new string(resultArray);                                        // Формуємо результат як рядок
        Console.WriteLine("Результат: " + result);

        File.WriteAllText(outputFilePath, result);                                      // Записуємо результат у файл
        Console.WriteLine($"Результат збережено у файл: {outputFilePath}");

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}