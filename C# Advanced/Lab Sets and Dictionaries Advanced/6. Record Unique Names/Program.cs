
HashSet<string> names = new();

int inputs = int.Parse(Console.ReadLine());

for (int i = 0; i < inputs; i++)
{
    names.Add(Console.ReadLine());
}

foreach (var name in names)
{
    Console.WriteLine(name);
}