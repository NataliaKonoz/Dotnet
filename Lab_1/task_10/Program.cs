using System;

class Program
{
    static void Main()
    {
        short n;        // параметр зовнішнього циклу
        double x, y;    // абсциса і ордината графіка
        short h;        // позиція точки на екрані

        // Налаштування кольорів для різних частин виводу
        Console.ForegroundColor = ConsoleColor.Cyan;  // Пояснюючий текст
        Console.WriteLine("|   x   |      y     |");
        Console.WriteLine("|-------|------------|");

        // зовнішній цикл - для 5 періодів
        for (n = 0; n < 5; n++)
        {
            // внутрішній цикл для одного періоду
            for (x = 0; x < 4; x += 0.25)
            {
                // Визначення ординати залежно від відрізку
                if (x < 2)
                    y = 2 * Math.Sin(0.8 * x);
                else if (x == 2)
                    y = 2;
                else
                    y = -2 * Math.Sin(0.8 * x);

                // Виведення абсциси і ординати з іншим кольором
                Console.ForegroundColor = ConsoleColor.Yellow;  // Числа
                Console.Write("| {0,5:0.00} | {1,10:0.0000000} |", x + n * 4, y);

                if (x == 2)
                {
                    // Спеціальний випадок для x = 2: Виведення кількох зірочок
                    Console.ForegroundColor = ConsoleColor.Green;  // Графік
                    Console.WriteLine(" *     *     *     *     *     *     *");
                }
                else
                {
                    // визначення позиції точки
                    h = (short)((y + 2) * 10);
                    if (y + 2 - h / 10.0 > 0.5) h++;

                    // Виведення графіку з використанням стандартних символів
                    Console.ForegroundColor = ConsoleColor.Green;  // Графік
                    for (; h > 0; h--) Console.Write(" ");
                    if (y > 0)
                        Console.WriteLine("-");
                    else if (y < 0)
                        Console.WriteLine("\\");
                    else
                        Console.WriteLine("*");  // Нульова лінія
                }
            }

            // Після кожного періоду розділити результати
            Console.ForegroundColor = ConsoleColor.Cyan;  // Пояснюючий текст
            Console.WriteLine("|----------------------|");
        }

        // Після завершення виведення
        Console.ForegroundColor = ConsoleColor.White;  // Виведення білого тексту
        Console.WriteLine("Натиснiть будь-яку клавiшу щоб завершити програму...");
        Console.ReadLine();

        // Повернення кольору до початкового
        Console.ResetColor();
    }
}