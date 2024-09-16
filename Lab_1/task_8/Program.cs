using System;
class Program
{
    static void Main()
    {
        // Введення точності та кількості членів ряду
        Console.Write("Введiть точнiсть: ");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть кiлькiсть членiв ряду: ");
        int maxTerms = Convert.ToInt32(Console.ReadLine());

        if (epsilon <= 0 || maxTerms <= 0)
        {
            Console.WriteLine("Помилка: точнiсть та кiлькiсть членiв ряду повиннi бути бiльшi за нуль.");
            return;
        }

        // Розрахунок суми ряду
        double sum = 0.0;
        double term;
        int n = 0;
        bool reachedEpsilon = false;

        while (n < maxTerms)
        {
            term = Math.Pow(-1, n) * (Math.Pow(2, n) / (Math.Pow(n, n + 1) + 1));
            sum += term;

            if (Math.Abs(term) <= epsilon)
            {
                reachedEpsilon = true;
                break;
            }

            n++;
        }

        // Виведення результатів
        if (reachedEpsilon)
        {
            Console.WriteLine($"Сума членiв ряду з точнiстю до {epsilon}: {sum}");
            Console.WriteLine("Сума розрахована за принципом досягнення заданої точностi.");
        }
        else
        {
            Console.WriteLine($"Сума перших {maxTerms} членiв ряду: {sum}");
            Console.WriteLine("Сума розрахована за принципом досягнення заданої кiлькостi членiв.");
        }

        // Очікування натискання будь-якої клавіші перед закриттям
        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}