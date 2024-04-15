

using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

int studentsNum = int.Parse(Console.ReadLine());

for (int i = 0; i < studentsNum; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input.First();
    decimal grade = decimal.Parse(input.Last());

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }

    students[name].Add(Math.Abs(grade));
}

foreach (var student in students)
{
    Console.Write($"{student.Key} ->");

    foreach (var grade in student.Value)
    {
        Console.Write($" {grade:f2}");
    }

    Console.WriteLine($" (avg: {student.Value.Average():f2})");
}