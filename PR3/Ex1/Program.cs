namespace Ex1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            RunEx1();
        }

        static void RunEx1()
        {
            string inputFilePath = @"D:\C# exercises\2 semestr\files\story.txt";
            string outputFilePath = @"C:\Users\Admin\Desktop\report.txt";

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new(inputFilePath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;

                    charCount += line.Length;

                    string[] words = line.Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            using (StreamWriter writer = new(outputFilePath))
            {
                writer.WriteLine($"Рядки: {lineCount}");
                writer.WriteLine($"Слова: {wordCount}");
                writer.WriteLine($"Символи: {charCount}");
            }
        }
    }
}
