using System;

class Program
{
    static void Main()
    {
        string name1, name2, name3;
        char sc1, sc2, sc3;
        int cnt1, cnt2, cnt3;
        int nom1, nom2, nom3;

        // Введення фактичних даних
        Console.WriteLine("1. Введiть: позначення, тип, номiнал, кiлькiсть >");
        var input1 = Console.ReadLine().Split(' ');
        name1 = input1[0];
        sc1 = Convert.ToChar(input1[1]);
        nom1 = Convert.ToInt32(input1[2]);
        cnt1 = Convert.ToInt32(input1[3]);

        Console.WriteLine("2. Введiть: позначення, тип, номiнал, кiлькiсть >");
        var input2 = Console.ReadLine().Split(' ');
        name2 = input2[0];
        sc2 = Convert.ToChar(input2[1]);
        nom2 = Convert.ToInt32(input2[2]);
        cnt2 = Convert.ToInt32(input2[3]);

        Console.WriteLine("3. Введiть: позначення, тип, номiнал, кiлькiсть >");
        var input3 = Console.ReadLine().Split(' ');
        name3 = input3[0];
        sc3 = Convert.ToChar(input3[1]);
        nom3 = Convert.ToInt32(input3[2]);
        cnt3 = Convert.ToInt32(input3[3]);

        // Налаштування кольорів
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Виведення таблиці з використанням псевдографіки
        Console.WriteLine("┌──────────────┬─────┬─────────┬───────────┐");
        Console.WriteLine("│   Позначення │ Тип │ Номiнал │ Кiлькiсть │");
        Console.WriteLine("├──────────────┼─────┼─────────┼───────────┤");

        // Виведення рядків фактичних даних з різними кольорами для чисел і тексту
        PrintRow(name1, sc1, nom1, cnt1);
        PrintRow(name2, sc2, nom2, cnt2);
        PrintRow(name3, sc3, nom3, cnt3);

        Console.WriteLine("└──────────────┴─────┴─────────┴───────────┘");

        // Виведення приміток
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Примiтка: R – резистор; C – конденсатор");

        // Повернення кольору за замовчуванням
        Console.ResetColor();
    }

    static void PrintRow(string name, char type, int nom, int cnt)
    {
        // Текст – інший колір
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"│ {name,-12} │ {type}   │ ");

        // Числа – окремий колір
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{nom,7} │ {cnt,9} │\n");

        // Повернення до кольору таблиці
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
