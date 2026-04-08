using System.Text.Json;

namespace Ex1
{
    internal class Program
    {
        static string filePath = "../../../tasks.json";
        static List<TaskItem> tasks = [];

        static void Main()
        {
            if (File.Exists(filePath))
            {
                var existTasks = JsonSerializer.Deserialize<List<TaskItem>>(File.ReadAllText(filePath));
                if (existTasks != null)
                    tasks = existTasks;
            }

            while (true)
            {
                Console.WriteLine("1 -- Add task:\n2 -- Change status:\n3 -- All tasks\n4 -- Exit program");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Task name: ");
                        tasks.Add(new TaskItem { Title = Console.ReadLine(), IsCompleted = false });
                        break;

                    case "2":

                        break;
                }
            }
        }
    }
}
