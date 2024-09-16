using System;

class Program
{
    static void Main()
    {
        float x, y;


        Console.Write("Введiть координату x: ");
        x = float.Parse(Console.ReadLine());


        Console.Write("Введiть координату y: ");
        y = float.Parse(Console.ReadLine());

                                                                        // Перевірка для першої чверті 
        if (x > 0 && y > 0 && (x * x + y * y <= 1))
        {
            Console.WriteLine("true");
        }
                                                                        // Перевірка для третьої чверті
        else if (x >= -1 && x <= 0 && y >= -1 && y <= 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
