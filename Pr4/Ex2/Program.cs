using System;
using System.Text.Json;
using System.Xml.Linq;

namespace Ex2
{
    internal class Program
    {
        private static string filePath = "students.json";

        static void Main()
        {
            List<Student> students =
            [
                new() { Name = "Marina", Age = 22, AverageScore = 4.0 },
                new() { Name = "Kolya",  Age = 23, AverageScore = 3.1 },
                new() { Name = "Misha",  Age = 24, AverageScore = 4.5 },
                new() { Name = "Tolya",  Age = 25, AverageScore = 3.6 },
                new() { Name = "Vasya",  Age = 26, AverageScore = 4.0 },
            ];

            Serialize(students);

            var list = Deserialize();

            PrintStudents(list);
        }

        static void Serialize(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Added {students.Count} students");
        }

        static List<Student> Deserialize()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File doesn`t exist");
                return [];
            }

            string json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<List<Student>>(json) ?? [];

            Console.WriteLine($"Readed {result.Count} students");
            return result;
        }

        static void PrintStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                Console.WriteLine($"│ {i+1} │ {student.Name} │ {student.Age}  │{student.AverageScore} │");
            }

        }
    }
}
