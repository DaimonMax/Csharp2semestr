namespace Ex3
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            RunEx3();
        }

        static void RunEx3()
        {
            string path = @"D:\C# exercises\2 semestr\files";

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена!");
                return;
            }

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            if (files.Length == 0)
            {
                Console.WriteLine("Файлів не знайдено!");
                return;
            }

            FileInfo? bigFile = null;

            foreach (string file in files)
            {
                FileInfo info = new(file);

                if (bigFile == null || info.Length > bigFile.Length)
                {
                    bigFile = info;
                }
            }

            Console.WriteLine("Найбільший файл:");
            Console.WriteLine($"Назва: {bigFile.Name}");
            Console.WriteLine($"Розмір найбільшого файлу: {bigFile.Length / 1024.0:F2} кілобайт");
            Console.WriteLine($"Путь до файлу: {bigFile.FullName}");
        }
    }
}
