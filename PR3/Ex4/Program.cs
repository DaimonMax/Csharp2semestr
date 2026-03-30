namespace Ex4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            RunEx4();
        }

        static void RunEx4()
        {
            string path = @"D:\C# exercises\2 semestr\files";

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена!");
                return;
            }

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            int deletedFiles = 0;
            long totalSize = 0;

            foreach (string file in files)
            {
                try
                {
                    FileInfo info = new(file);

                    totalSize += info.Length; 
                    File.Delete(file);
                    deletedFiles++;
                }
                catch (Exception) { }
            }

            Console.WriteLine($"Видалено файлів: {deletedFiles}");
            Console.WriteLine($"Звільнено місця: {totalSize / 1024.0:F2} кілобайт");
        }
    }
}
