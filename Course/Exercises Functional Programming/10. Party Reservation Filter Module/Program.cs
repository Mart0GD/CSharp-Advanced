

Dictionary<string, Predicate<string>> filters = new();

List<string> people = Console.ReadLine().Split().ToList();

string command;
while ((command = Console.ReadLine()) != "Print")
{
    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string type = tokens[1];
    string value = tokens[2];

    if (action == "Add filter")
    {
        if (!filters.ContainsKey(type))
        {
            filters.Add(type + value, GetPredicate(type, value));
        }
    }
    else
    {
        if (filters.ContainsKey(type + value))
        {
            filters.Remove(type + value);
        }
    }
}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", people));


Predicate<string> GetPredicate(string command, string value)
{
    switch (command)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
        default:
            return null;
    }
}