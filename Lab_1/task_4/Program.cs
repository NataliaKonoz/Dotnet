using System;

class Program
{
    static void Main()
    {
        try
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

            if (x <= 0)
            {
                throw new ArgumentException("Значення x має бути бiльше нуля для обчислення логарифма.");
            }

            if (a == 0)
            {
                throw new DivideByZeroException("Значення a не може дорівнювати нулю.");
            }

            // Обчислення t1
            double t1 = (1 / Math.Pow(a, 3)) * (Math.Log(x) + (2 * b) / x - Math.Pow(b, 2) / (2 * Math.Pow(x, 2)));

            // Обчислення t2
            double ax = a * x;
            if (Math.Sin(ax) == 0)
            {
                throw new DivideByZeroException("Ділення на нуль під час обчислення t2: sin(ax) не може бути нулем.");
            }

            double t2 = (Math.Cos(ax) / (2 * a * Math.Pow(Math.Sin(ax), 2))) + (1 / (2 * a)) * Math.Log(Math.Tan(ax / 2));

            // Виведення результатів
            Console.WriteLine($"Значення t1 = {t1}");
            Console.WriteLine($"Значення t2 = {t2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату введених даних. Введіть числові значення.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Невідома помилка: {ex.Message}");
        }
        finally
        {
            // Очікування натискання будь-якої клавіші перед закриттям
            Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
            Console.ReadKey();
        }
    }
}