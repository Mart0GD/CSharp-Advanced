

using System.Security.Cryptography.X509Certificates;

Func<int, List<int>> fillList = end =>
{
    List<int> result = new List<int>();

    for (int i = 1; i <= end; i++)
    {
        result.Add(i);
    }

    return result;
};


List<int> range = fillList(int.Parse(Console.ReadLine()));

HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

List<Predicate<int>> predicats = new();

foreach (var divider in dividers)
{
    predicats.Add(n => n % divider == 0);
}

foreach (var number in range)
{
    bool dividable = true;

    foreach (var predicat in predicats)
    {
        if (!predicat(number))
        {
            dividable = false;
        }
    }

    if (dividable)
    {
        Console.Write(number + " ");
    }
}
