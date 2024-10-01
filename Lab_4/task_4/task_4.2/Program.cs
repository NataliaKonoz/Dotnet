using System;
using System.Collections.Generic;

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

    public string Name
    {
        get { return _name; }
        set { _name = value; }
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

    public void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Термiн зберiгання: {_shelfLife} днiв, Кiлькiсть: {_quantity}");
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
            decimal price = Math.Round((decimal)(rnd.NextDouble() * 95 + 5), 2);
            int shelfLife = rnd.Next(1, 365);
            int quantity = rnd.Next(1, 50);
            products.Add(new Product(name, manufacturer, price, shelfLife, quantity));
        }

        return products;
    }
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

    public void RemoveProductAt(int index)
    {
        if (index >= 0 && index < _products.Count)
        {
            Product product = _products[index];
            _products.RemoveAt(index);
            Console.WriteLine($"Товар {product.Name} (iндекс {index}) видалено з магазину {_storeName}.");
        }
        else
        {
            Console.WriteLine($"Iндекс {index} поза межами списку товарiв.");
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

        List<Product> products = Product.GenerateRandomProducts(5);

        foreach (var product in products)
        {
            store1.AddProduct(product);
        }

        store1.DisplayProducts();

        store2.AddProduct(products[0]);
        store2.DisplayProducts();

        store1.RemoveProductAt(2); 

        store1.DisplayProducts();

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}