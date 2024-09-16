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
        bool isInsideCircle = (x > 0 && y > 0 && (x * x + y * y <= 1));

                                                                                 // Перевірка для третьої чверті
        bool isInsideSquare = (x >= -1 && x <= 0 && y >= -1 && y <= 0);

  
        bool result = isInsideCircle || isInsideSquare;

        Console.WriteLine(result ? "true" : "false");
    }
}