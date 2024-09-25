using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок: ");                       // Вводимо рядок, який потрібно скопіювати
        string inputString = Console.ReadLine();

        Console.Write("Введiть довжину другого рядка: ");
        int desiredLength;

        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length) {    // Перевірка правильності введення
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        int spacesBefore = (desiredLength - inputString.Length) / 2;                    // Обчислюємо відстань для центрування
        char[] resultArray = new string('0', desiredLength).ToCharArray();              // Створюємо рядок з нулями

        for (int i = 0; i < inputString.Length; i++) {                                  // Вставляємо текст першого рядка в центр другого
            resultArray[spacesBefore + i] = inputString[i];
        }

        Console.WriteLine("Результат: " + new string(resultArray));

        string abbreviation = CreateAbbreviation(inputString);                          // Складання абревіатури
        Console.WriteLine("Абревiатура: " + abbreviation);

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
    static string CreateAbbreviation(string input) {                // Метод для створення абревіатури з перших літер слів
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);    // Розбиваємо рядок на слова

        string abbreviation = "";
        foreach (string word in words) {        // Беремо перші літери кожного слова
            abbreviation += word[0];            // Додаємо першу літеру кожного слова
        }

        return abbreviation.ToUpper();          // Повертаємо абревіатуру великими літерами
    }
}