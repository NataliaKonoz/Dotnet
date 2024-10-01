using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    private string _name;
    private string _manufacturer;
    private decimal _price;
    private int _shelfLife;
    private int _quantity;

    public Product(string name, string manufacturer, decimal price, int shelfLife, int quantity)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
        _shelfLife = shelfLife;
        _quantity = quantity;
    }

    public void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Термiн зберiгання: {_shelfLife} днiв, Кiлькiсть: {_quantity}");
    }

    public string Name => _name;
    public int ShelfLife => _shelfLife;
}

class Store
{
    private string _storeName;
    private List<Product> _products;

    public Store(string storeName)
    {
        _storeName = storeName;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine($"Товар {product.Name} додано до магазину {_storeName}.");
    }

    public void RemoveProduct(Product product)
    {
        if (_products.Remove(product))
        {
            Console.WriteLine($"Товар {product.Name} видалено з магазину {_storeName}.");
        }
        else
        {
            Console.WriteLine($"Товар {product.Name} не знайдено в магазинi {_storeName}.");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine($"\nСписок товарiв в магазинi {_storeName}:");
        foreach (var product in _products)
        {
            product.Show();
        }
    }
}

class Program
{
    static void Main()
    {
        Store store1 = new Store("Магазин продуктiв 1");
        Store store2 = new Store("Магазин продуктiв 2");

        List<Product> products = GenerateRandomProducts(5);

        foreach (var product in products)
        {
            store1.AddProduct(product);
        }

        store2.DisplayProducts();
        store1.DisplayProducts();

        Product productToMove = products[0];
        store1.RemoveProduct(productToMove);
        store2.AddProduct(productToMove);

        Console.WriteLine("\nПiсля перемiщення продукту:");
        store1.DisplayProducts();
        store2.DisplayProducts();

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }

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