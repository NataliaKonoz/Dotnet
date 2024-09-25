using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок: ");
        string inputString = Console.ReadLine();

        Console.Write("Введiть довжину другого рядка: ");
        int desiredLength;

        while (!int.TryParse(Console.ReadLine(), out desiredLength) || desiredLength < inputString.Length)
        {
            Console.Write("Некоректна довжина. Введiть довжину, що бiльша або рiвна довжинi першого рядка: ");
        }

        int spacesBefore = (desiredLength - inputString.Length) / 2;
        char[] resultArray = new string('0', desiredLength).ToCharArray();

        for (int i = 0; i < inputString.Length; i++)
        {
            resultArray[spacesBefore + i] = inputString[i];
        }

        string resultString = new string(resultArray);
        string abbreviation = CreateAbbreviation(inputString);

        // Запис результатів у двійковий файл
        using (BinaryWriter writer = new BinaryWriter(File.Open("../result.bin", FileMode.Create)))
        {
            writer.Write(resultString);
            writer.Write(abbreviation);
        }

        Console.WriteLine("Данi записано до двiйкового файлу.");

        // Читання та виведення даних із двійкового файлу
        using (BinaryReader reader = new BinaryReader(File.Open("../result.bin", FileMode.Open)))
        {
            string readResultString = reader.ReadString();
            string readAbbreviation = reader.ReadString();

            Console.WriteLine("З файлу:");
            Console.WriteLine("Результат: " + readResultString);
            Console.WriteLine("Абревiатура: " + readAbbreviation);
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

    static string CreateAbbreviation(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        string abbreviation = "";
        foreach (string word in words)
        {
            abbreviation += word[0];
        }

        return abbreviation.ToUpper();
    }
}
