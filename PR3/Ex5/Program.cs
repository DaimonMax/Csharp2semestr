namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            if (args.Length == 0)
            {
                return;
            }

            string path = args[0];

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папка не знайдена!");
                return;
            }

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            long totalSize = 0;
            FileInfo? BigFile = null;

            foreach (string file in files)
            {
                try
                {
                    FileInfo info = new(file);

                    totalSize += info.Length;

                    if (BigFile == null || info.Length > BigFile.Length)
                    {
                        BigFile = info;
                    }
                }
                catch (Exception) { }
            }

            Console.WriteLine($"Папки: {dirs.Length}");
            Console.WriteLine($"Файли: {files.Length}");
            Console.WriteLine($"Розмір: {totalSize / 1024.0 / 1024.0:F2} мегабайтів");

            if (BigFile != null)
            {
                Console.WriteLine($"Найбільший файл: {BigFile.Name}");
            }
        }


    }
}
