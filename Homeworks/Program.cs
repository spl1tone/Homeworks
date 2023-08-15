namespace Homeworks;

public class Program
{
    // homework-OOP-Classes
    static void Main (string[] args)
    {
        Books book1 = new Books(1, "Book1", "Nice1", "Vlad1", 1001, 2022);
        book1.PrintBook();
        Console.WriteLine();
        Books book2 = new Books(2, "Book2", "Nice2", "Vlad2", 1002, 2023);
        book2.PrintBook();

        BooksTest booksTest = new();
        booksTest.TestValidBook();
        booksTest.TestInvalidId();
        booksTest.TestInvalidYear();

    }
}