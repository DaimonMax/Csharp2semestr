using System.Text.Json;

namespace Ex3
{
    internal class Program
    {
        static void Main()
        {
            Author author = new()
            {
                Name = "Lovecraft",
                Books = []
            };

            author.Books.Add(new Book { Title = "The call of Cthulhu", Author = author });
            author.Books.Add(new Book { Title = "The shadow out of time", Author = author });

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(author, options);
            Console.WriteLine(json);
        }
    }
}
