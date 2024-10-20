class ExpirationDate
{
    public DateTime ManufactureDate { get; set; }
    public int ShelfLifeDays { get; set; }

    public ExpirationDate(DateTime manufactureDate, int shelfLifeDays)
    {
        ManufactureDate = manufactureDate;
        ShelfLifeDays = shelfLifeDays;
    }

    public DateTime GetExpirationDate()
    {
        return ManufactureDate.AddDays(ShelfLifeDays);
    }

    public void ShowExpirationDetails()
    {
        Console.WriteLine($"Дата виготовлення: {ManufactureDate.ToShortDateString()}, Термiн придатностi: {ShelfLifeDays} днiв, Кiнцева дата: {GetExpirationDate().ToShortDateString()}");
    }
}
class Product
{
    private string _name;
    private string _manufacturer;
    private decimal _price;
    private int _quantity;
    private ExpirationDate _expirationDate;
    public Product(string name, string manufacturer, decimal price, int quantity, ExpirationDate expirationDate)
    {
        _name = name;
        _manufacturer = manufacturer;
        _price = price;
        _quantity = quantity;
        _expirationDate = expirationDate;
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

    public void Show()
    {
        Console.WriteLine($"Назва: {_name}, Виробник: {_manufacturer}, Цiна: {_price}, Кiлькiсть: {_quantity}");
        _expirationDate.ShowExpirationDetails();
    }

    public void DeleteProduct()
    {
        Console.WriteLine($"Продукт {_name} видалено разом з його термiном придатностi.");
        _expirationDate = null;
    }
}

class Program
{
    static void Main()
    {
        ExpirationDate expDate1 = new ExpirationDate(DateTime.Now.AddDays(-10), 30);
        ExpirationDate expDate2 = new ExpirationDate(DateTime.Now.AddDays(-5), 10);

        Product product1 = new Product("Молоко", "Виробник1", 35.99m, 10, expDate1);
        Product product2 = new Product("Хлiб", "Виробник2", 15.50m, 25, expDate2);

        Console.WriteLine("Список продуктiв до видалення:");
        product1.Show();
        product2.Show();

        product1.DeleteProduct();

        Console.WriteLine("\nСписок продуктiв пiсля видалення першого:");
        product2.Show();

        Console.WriteLine("Натиснiть будь-яку клавiшу, щоб завершити програму...");
        Console.ReadKey();
    }
}
