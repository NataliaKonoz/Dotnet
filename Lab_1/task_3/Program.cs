using System;

class Program
{
    static void Main()
    {
        // Початкові значення змінних
        double a = 2.0; 
        double b = 3.0;
        int m = 5;      
        int n = 2;  

        // Введення значень для x та y
        Console.Write("Введiть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть значення y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Перевірка допустимих значень
        if (x <= 0)
        {
            Console.WriteLine("Значення x має бути бiльше нуля для обчислення логарифма.");
            return;
        }

        // Обчислення t1
        double t1 = (1 / Math.Pow(a, 3)) * (Math.Log(x) + (2 * b) / x - Math.Pow(b, 2) / (2 * Math.Pow(x, 2)));

        // Обчислення t2
        double ax = a * x;
        double t2 = (Math.Cos(ax) / (2 * a * Math.Pow(Math.Sin(ax), 2))) + (1 / (2 * a)) * Math.Log(Math.Tan(ax / 2));

        Console.WriteLine($"Значення t1 = {t1}");
        Console.WriteLine($"Значення t2 = {t2}");

        // Очікування натискання будь-якої клавіші перед закриттям
        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}