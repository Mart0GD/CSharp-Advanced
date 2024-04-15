

HashSet<string> names = new();

int times = int.Parse(Console.ReadLine());

for (int i = 0; i < times; i++)
{
    names.Add(Console.ReadLine());
}

foreach (var name in names)
{
    Console.WriteLine(name);
}