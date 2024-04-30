class Book
{
    private string title;
    private double price;

    public Book(string title, double price)
    {
        this.title = title;
        this.price = price;
    }

    public string GetTitle()
    {
        return title;
    }

    public double GetPrice()
    {
        return price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {title}, Цена: {price} руб.");
    }
}

class HardcoverBook : Book
{
    private string coverMaterial;

    public HardcoverBook(string title, double price, string coverMaterial)
        : base(title, price)
    {
        this.coverMaterial = coverMaterial;
    }

    public void DisplayCoverInfo()
    {
        Console.WriteLine($"Материал обложки: {coverMaterial}");
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        DisplayCoverInfo();
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("Преступление и наказание", 500);

        HardcoverBook hardcoverBook = new HardcoverBook("Мастер и Маргарита", 700, "твердая");

        book.DisplayInfo();
        hardcoverBook.DisplayInfo();
    }
}