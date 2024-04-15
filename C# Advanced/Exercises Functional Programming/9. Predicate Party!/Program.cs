
List<string> people = Console.ReadLine().Split().ToList();

string command;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split();

    string action = tokens[0];
    string type = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(type, value));
    }
    else
    {
        List<string> peopletoDouble = people.Where(x => GetPredicate(type, value)(x)).ToList();
        List<int> indexes = new();

        foreach (var person in peopletoDouble)
        {
            people.Insert(people.IndexOf(person), person);
        }

    }
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

Predicate<string> GetPredicate(string command, string value)
{
    switch (command)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return null;
    }
}