using System;
using System.Collections.Generic;
using System.Linq;

// Абстрактний клас для загальних властивостей продукту
public abstract class BaseProduct
{
    public abstract string Name { get; set; }
    public abstract string Manufacturer { get; set; }
    public abstract decimal Price { get; set; }
    public abstract int ShelfLife { get; set; }
    public abstract int Quantity { get; set; }

    public abstract void Show();
    public abstract bool IsShelfLifeGreaterThan(int days);

    // Статичний метод для генерації випадкових продуктів
    public static List<BaseProduct> GenerateRandomProducts(int count)
    {
        Random rnd = new Random();
        List<BaseProduct> products = new List<BaseProduct>();

        // Масиви назв для молочних і м'ясних продуктів
        string[] dairyNames = { "Молоко", "Сир", "Йогурт", "Сметана", "Творог" };
        string[] meatNames = { "Серце", "Печiнка", "Фiле", "Нирки", "Туша" };

        string[] manufacturers = { "Виробник1", "Виробник2", "Виробник3" };
        string[] typesOfMeat = { "Курка", "Яловичина", "Свинина", "Індейка", "Баранина" };
        string[] cheeseTypes = { "Голландський", "Пармезан", "Моцарела" };
        string[] yogurtFlavors = { "Полуниця", "Ванiль", "Шоколад" };

        for (int i = 0; i < count; i++)
        {
            if (rnd.Next(3) == 0)
            {
                string name = "Сир";
                string manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
                decimal price = rnd.Next(5, 100);
                int shelfLife = rnd.Next(1, 365);
                int quantity = rnd.Next(1, 50);
                string fatContent = $"{rnd.Next(1, 21)}%";
                string cheeseType = cheeseTypes[rnd.Next(cheeseTypes.Length)];
                bool isAged = rnd.Next(2) == 0;

                products.Add(new Cheese(name, manufacturer, price, shelfLife, quantity, fatContent, cheeseType, isAged));
            }
            else if (rnd.Next(3) == 1)
            {
                string name = "Йогурт";
                string manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
                decimal price = rnd.Next(5, 100);
                int shelfLife = rnd.Next(1, 365);
                int quantity = rnd.Next(1, 50);
                string fatContent = $"{rnd.Next(1, 21)}%";
                bool isProbiotic = rnd.Next(2) == 0;
                string flavor = yogurtFlavors[rnd.Next(yogurtFlavors.Length)];

                products.Add(new Yogurt(name, manufacturer, price, shelfLife, quantity, fatContent, isProbiotic, flavor));
            }
            else
            {
                string name = meatNames[rnd.Next(meatNames.Length)];
                string manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
                decimal price = rnd.Next(5, 100);
                int shelfLife = rnd.Next(1, 365);
                int quantity = rnd.Next(1, 50);
                string typeOfMeat = typesOfMeat[rnd.Next(typesOfMeat.Length)];

                products.Add(new MeatProduct(name, manufacturer, price, shelfLife, quantity, typeOfMeat));
            }
        }

        return products;
    }

}

// Клас DairyProduct, що реалізує абстрактний клас BaseProduct
public class DairyProduct : BaseProduct
{
    private string _name;
    private string _manufacturer;
    private decimal _price;
    private int _shelfLife;
    private int _quantity;
    public string FatContent { get; set; }

    // Конструктор
    public DairyProduct(string name, string manufacturer, decimal price, int shelfLife, int quantity, string fatContent)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
        _shelfLife = shelfLife;
        _quantity = quantity;
        FatContent = fatContent;
    }

    // Властивості з реалізацією абстрактного класу
    public override string Name { get => _name; set => _name = value; }
    public override string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
    public override decimal Price { get => _price; set => _price = value; }
    public override int ShelfLife { get => _shelfLife; set => _shelfLife = value; }
    public override int Quantity { get => _quantity; set => _quantity = value; }

    public override void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Термiн зберiгання: {_shelfLife} днiв, Кiлькiсть: {_quantity}, Жирнiсть: {FatContent}");
    }

    public override bool IsShelfLifeGreaterThan(int days)
    {
        return _shelfLife > days;
    }
}

// Клас Cheese, що наслідує DairyProduct
public class Cheese : DairyProduct
{
    public string CheeseType { get; set; }
    public bool IsAged { get; set; }

    public Cheese(string name, string manufacturer, decimal price, int shelfLife, int quantity, string fatContent, string cheeseType, bool isAged)
        : base(name, manufacturer, price, shelfLife, quantity, fatContent)
    {
        CheeseType = cheeseType;
        IsAged = isAged;
    }

    public void ShowCheeseInfo()
    {
        Console.WriteLine($"Тип сиру: {CheeseType}, Витриманий: {IsAged}");
    }

    public override void Show()
    {
        base.Show();
        ShowCheeseInfo();
    }
}

// Клас Yogurt, що наслідує DairyProduct
public class Yogurt : DairyProduct
{
    public bool IsProbiotic { get; set; } 
    public string Flavor { get; set; }

    public Yogurt(string name, string manufacturer, decimal price, int shelfLife, int quantity, string fatContent, bool isProbiotic, string flavor)
        : base(name, manufacturer, price, shelfLife, quantity, fatContent)
    {
        IsProbiotic = isProbiotic;
        Flavor = flavor;
    }

    public void ShowYogurtInfo()
    {
        Console.WriteLine($"Пробiотичний: {IsProbiotic}, Смак: {Flavor}");
    }

    public override void Show()
    {
        base.Show();
        ShowYogurtInfo();
    }
}

// Клас MeatProduct, що реалізує абстрактний клас BaseProduct
public class MeatProduct : BaseProduct
{
    private string _name;
    private string _manufacturer;
    private decimal _price;
    private int _shelfLife;
    private int _quantity;
    public string TypeOfMeat { get; set; }

    // Конструктор
    public MeatProduct(string name, string manufacturer, decimal price, int shelfLife, int quantity, string typeOfMeat)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
        _shelfLife = shelfLife;
        _quantity = quantity;
        TypeOfMeat = typeOfMeat;
    }

    // Властивості з реалізацією абстрактного класу
    public override string Name { get => _name; set => _name = value; }
    public override string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
    public override decimal Price { get => _price; set => _price = value; }
    public override int ShelfLife { get => _shelfLife; set => _shelfLife = value; }
    public override int Quantity { get => _quantity; set => _quantity = value; }

    public override void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Термiн зберiгання: {_shelfLife} днiв, Кiлькiсть: {_quantity}, Тип м'яса: {TypeOfMeat}");
    }

    public override bool IsShelfLifeGreaterThan(int days)
    {
        return _shelfLife > days;
    }
}

class Program
{
    static void Main()
    {
        List<BaseProduct> products = BaseProduct.GenerateRandomProducts(10);

        Console.WriteLine("Усi товари:");
        foreach (var product in products)
        {
            product.Show();
            Console.WriteLine();
        }

        Console.WriteLine("\nВведiть найменування для пошуку:");
        string searchName = Console.ReadLine();

        var filteredByName = products.Where(p => p.Name == searchName).ToList();
        Console.WriteLine("\nТовари для заданого найменування:");
        foreach (var product in filteredByName)
        {
            product.Show();
        }

        Console.WriteLine("\nВведiть максимальну цiну:");
        decimal maxPrice = Convert.ToDecimal(Console.ReadLine());

        var filteredByPrice = filteredByName.Where(p => p.Price <= maxPrice).ToList();
        Console.WriteLine("\nТовари, що вiдповiдають зазначенiй цiнi:");
        foreach (var product in filteredByPrice)
        {
            product.Show();
        }

        Console.WriteLine("\nВведiть мiнiмальний термiн зберiгання (днi):");
        int minShelfLife = Convert.ToInt32(Console.ReadLine());

        var filteredByShelfLife = filteredByPrice.Where(p => p.IsShelfLifeGreaterThan(minShelfLife)).ToList();
        Console.WriteLine("\nТовари з бiльшим термiном зберiгання:");
        foreach (var product in filteredByShelfLife)
        {
            product.Show();
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}
