using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ex4
{
    internal class Program
    {
        static void Main()
        {
            List<Order> orders =
            [
                new() { Id = 1, Status = OrderStatus.Added },
                new() { Id = 2, Status = OrderStatus.Processing },
                new() { Id = 3, Status = OrderStatus.Completed },
                new() { Id = 4, Status = OrderStatus.Ready }
            ];

            JsonSerializerOptions options = new()
            {
                Converters = { new JsonStringEnumConverter() },
                WriteIndented = true
            };

            string number = JsonSerializer.Serialize(orders);
            Console.WriteLine(number);

            string text = JsonSerializer.Serialize(orders, options);
            Console.WriteLine(text);

            List<Order>? deserialization = JsonSerializer.Deserialize<List<Order>>(text, options);
            if (deserialization != null)
            {
                foreach (var d in deserialization)
                    Console.WriteLine($"Id: {d.Id}, Status: {d.Status}");
            }
        }
    }
}
