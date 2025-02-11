using ConsoleApp15;

class Program
{
    static void Main()
    {
        // Yazarlar listesi
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Ahmet Hamdi Tanpınar" },
            new Author { AuthorId = 2, Name = "Orhan Pamuk" },
            new Author { AuthorId = 3, Name = "Elif Şafak" }
        };

        // Kitaplar listesi
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Saatleri Ayarlama Enstitüsü", AuthorId = 1 },
            new Book { BookId = 2, Title = "Kara Kitap", AuthorId = 2 },
            new Book { BookId = 3, Title = "İstanbul: Hatıralar ve Şehir", AuthorId = 2 },
            new Book { BookId = 4, Title = "Aşk", AuthorId = 3 }
        };

        // LINQ Join Sorgusu
        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId
                    select new { book.Title, author.Name };

        // Sonuçları yazdır
        Console.WriteLine("Kitaplar ve Yazarları:");
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.Title}, Yazar: {item.Name}");
        }
    }
}