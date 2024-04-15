

int inputs = int.Parse(Console.ReadLine());

SortedSet<string> chemicalCompounds = new(Console.ReadLine().Split());

for (int i = 0; i < inputs - 1; i++)
{
    HashSet<string> elements = Console.ReadLine().Split().ToHashSet();

    chemicalCompounds.UnionWith(elements);
}

Console.WriteLine(string.Join(" ", chemicalCompounds));