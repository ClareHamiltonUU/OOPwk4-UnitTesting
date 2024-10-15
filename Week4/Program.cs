class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string [] args)
    {
        // Create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456677";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";
        book2.NoOfPages = 50;

        // Output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }

}
