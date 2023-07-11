namespace Homeworks;

public class Books
{
    int year;
    int id;

    public int IdBook
    {
        get
        {
            return id;
        }
        set
        {
            if (value < 0) Console.WriteLine("Wrong Id");
            else id = value;
        }
    }
    public string BookName { get; set; } = "Name";
    public string Title { get; set; } = "Title";
    public string Author { get; set; } = "Author";
    public int Price { get; set; } = 0;
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value > 2023) Console.WriteLine("Wrong Date");
            else year = value;
        }

    }

    public Books () { }

    public Books (string bookname, string author)
    {
        BookName = bookname;
        Author = author;
    }

    public Books (int id, string bookname, string title, string author, int price, int year)
    {
        IdBook = id;
        BookName = bookname;
        Title = title;
        Author = author;
        Price = price;
        Year = year;
    }

    public void PrintBook ()
    {
        Console.WriteLine($"BookId: {IdBook}\n" +
            $"BookName: {BookName}\n" +
            $"Title: {Title}\n" +
            $"Author: {Author}\n" +
            $"Price: {Price}\n" +
            $"Year: {Year}");
    }

}
