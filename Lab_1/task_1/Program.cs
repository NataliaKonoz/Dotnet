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

        Console.WriteLine("3. Введiть: позначення, тип, номiнал, кiлькicть >");
        var input3 = Console.ReadLine().Split(' ');
        name3 = input3[0];
        sc3 = Convert.ToChar(input3[1]);
        nom3 = Convert.ToInt32(input3[2]);
        cnt3 = Convert.ToInt32(input3[3]);

        // Виведення таблиці
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("|          Вiдомiсть комплектуючих         |");
        Console.WriteLine("|------------------------------------------|");
        Console.WriteLine("|  Позначення  | Тип | Номiнал | Кiлькiсть |");
        Console.WriteLine("|--------------|-----|---------|-----------|");

        // Виведення рядків фактичних даних
        Console.WriteLine($"| {name1,-12} | {sc1}   | {nom1,7} | {cnt1,8}  |");
        Console.WriteLine($"| {name2,-12} | {sc2}   | {nom2,7} | {cnt2,8}  |");
        Console.WriteLine($"| {name3,-12} | {sc3}   | {nom3,7} | {cnt3,8}  |");

        // Виведення приміток
        Console.WriteLine("|------------------------------------------|");
        Console.WriteLine("|Примiтка: R – резистор; C – конденсатор   |");
        Console.WriteLine("--------------------------------------------");
    }
}