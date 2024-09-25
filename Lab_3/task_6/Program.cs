using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть текстовий рядок:");
        string input = Console.ReadLine();

        int numberCount = Regex.Matches(input, @"\b\d+\b").Count;                       // a) Підрахунок кількості чисел у тексті
        Console.WriteLine($"Кiлькiсть чисел у текстi: {numberCount}");

        var latinWords = input.Split(' ')                                               // б) Виведення слів, що складаються тільки з латинських літер
                              .Where(word => Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                              .ToList();

        if (latinWords.Count > 0) {
            Console.WriteLine("Слова, що складаються тiльки з латинських лiтер:");
            foreach (var word in latinWords) {
                Console.WriteLine(word);
            }
        }
        else {
            Console.WriteLine("У текстi немає слiв з лише латинськими лiтерами.");
        }

        var words = input.Split(' ').ToList();                                          // в) Видалення кожного другого слова
        for (int i = 1; i < words.Count; i += 2) {
            words[i] = string.Empty;                                                    // Видаляємо кожне друге слово
        }

        string result = string.Join(" ", words.Where(w => !string.IsNullOrWhiteSpace(w)));
        Console.WriteLine($"Текст пiсля видалення кожного другого слова: {result}");

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}