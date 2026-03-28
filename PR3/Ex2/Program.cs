namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunEx2();
        }

        static void RunEx2()
        {
            string path = @"D:\C# exercises\2 semestr\files";

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена");
                return;
            }

            string[] directories = Directory.GetDirectories(path);

            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo info = new(file);

                Console.WriteLine($"Назва: {info.Name}");
                Console.WriteLine($"Розмір: {info.Length}");
                Console.WriteLine($"Дата створення: {info.CreationTime}");
                Console.WriteLine("----------------------------------------------------------------");
            }
        }
    }
}
