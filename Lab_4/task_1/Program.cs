using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    // Приватні поля
    private string _name;
    private string _manufacturer;
    private decimal _price;
    private int _shelfLife;
    private int _quantity;

    // Конструктор
    public Product(string name, string manufacturer, decimal price, int shelfLife, int quantity)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
        _shelfLife = shelfLife;
        _quantity = quantity;
    }

    // Методи set та get
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Manufacturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int ShelfLife
    {
        get { return _shelfLife; }
        set { _shelfLife = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    // Додаткові методи
    public void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Термiн зберiгання: {_shelfLife} днiв, Кiлькiсть: {_quantity}");
    }

    public bool IsShelfLifeGreaterThan(int days)
    {
        return _shelfLife > days;
    }

    // Статичний метод для генерації випадкових продуктів
    public static List<Product> GenerateRandomProducts(int count)
    {
        Random rnd = new Random();
        List<Product> products = new List<Product>();
        string[] names = { "Молоко", "Хлiб", "Сир", "Йогурт", "М'ясо" };
        string[] manufacturers = { "Виробник1", "Виробник2", "Виробник3" };

        for (int i = 0; i < count; i++)
        {
            string name = names[rnd.Next(names.Length)];
            string manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
            decimal price = rnd.Next(5, 100);
            int shelfLife = rnd.Next(1, 365);
            int quantity = rnd.Next(1, 50);
            products.Add(new Product(name, manufacturer, price, shelfLife, quantity));
        }

        return products;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = Product.GenerateRandomProducts(10);

        Console.WriteLine("Усi товари:");
        foreach (var product in products)
        {
            product.Show();
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

        var filteredByShelfLife = products.Where(p => p.IsShelfLifeGreaterThan(minShelfLife)).ToList();
        Console.WriteLine("\nТовари з бiльшим термiном зберiгання:");
        foreach (var product in filteredByShelfLife)
        {
            product.Show();
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}
