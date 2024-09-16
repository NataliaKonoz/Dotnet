using System;

class Program
{
    static void Main()
    {
        // Визначення точності
        const double epsilon = 0.000000001;
        double sum = 0.0;
        double term;
        int n = 0;

        // Сума членів ряду до досягнення точності
        do
        {
            term = Math.Pow(-1, n) * (Math.Pow(2, n) / (Math.Pow(n, n + 1) + 1));
            sum += term;
            n++;
        } while (Math.Abs(term) > epsilon);
        Console.WriteLine($"Сума членiв ряду з точнiстю до 0.000000001: {sum}");

        // Сума перших 10 членів ряду
        double sumFirst10 = 0.0;
        for (int i = 0; i < 10; i++)
        {
            double currentTerm = Math.Pow(-1, i) * (Math.Pow(2, i) / (Math.Pow(i, i + 1) + 1));
            sumFirst10 += currentTerm;
        }
        Console.WriteLine($"Сума перших 10 членiв ряду: {sumFirst10}");

        // Очікування натискання будь-якої клавіші перед закриттям
        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}