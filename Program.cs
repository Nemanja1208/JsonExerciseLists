using System.Text.Json;

namespace JsonExerciseLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If you want to use only an array of books without a wrapper class:
            //string filePath = "books.json";
            //string json = File.ReadAllText(filePath);
            //var books = JsonSerializer.Deserialize<List<Book>>(json);

            // If you want to use only different data in the same json as books, authors etc...
            // Then you need a wrapper class like Library to hold the array of books.
            string filePath = "booksList.json";
            string json = File.ReadAllText(filePath);
            var library = JsonSerializer.Deserialize<Library>(json);

            foreach (var book in library.Books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Year}) - {book.Genre} - ${book.Price}");
            }
        }
    }
}
