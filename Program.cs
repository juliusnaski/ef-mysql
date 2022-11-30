using MySqlFire.Data;

CreateDbSeedData();
PrintPublishers();
PrintBooks();

static void CreateDbSeedData()
{
    using (var context = new LibraryContext())
    {
        context.Database.EnsureCreated();
    }
}

static void PrintBooks()
{
    using (var context = new LibraryContext())
    {
        var books = context.Books!
          .Include(p => p.Publisher);
        Console.WriteLine(new string('=', 30));
        foreach (var book in books!)
        {
            Console.WriteLine(book);
        }
    }
}

static void PrintPublishers()
{
    using (var context = new LibraryContext())
    {
        var data = context.Publishers;
        Console.WriteLine(new string('=', 30));
        foreach (var item in data!)
        {
            Console.WriteLine(item);
        }
    }
}
