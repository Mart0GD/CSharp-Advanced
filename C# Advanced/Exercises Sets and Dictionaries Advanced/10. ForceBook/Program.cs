


using System.Reflection.Metadata;

//Dictionary<string, int> forceSides = new();
Dictionary<string, string> forceUsers = new();

string command;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{ 

    bool add = command.Contains(" | ");

    if (add)
    {
        string forceSide = command.Split(" | ")[0];
        string forceUser = command.Split(" | ")[1];

        if (!forceUsers.ContainsKey(forceUser))
        {
            forceUsers.Add(forceUser, forceSide);
        }

    }
    else
    {
        string forceSide = command.Split(" -> ")[1];
        string forceUser = command.Split(" -> ")[0];

        if (forceUsers.ContainsKey(forceUser))
        {
            forceUsers[forceUser] = forceSide;

            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }
        else
        {
            forceUsers.Add(forceUser, forceSide);

            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }

    }
}

Dictionary<string, int> sides = new();

foreach (var user in forceUsers)
{
    if (!sides.ContainsKey(user.Value))
    {
        sides.Add(user.Value, 0);
    }

    sides[user.Value]++;
}

foreach (var side in sides.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    if (side.Value > 0)
    {
        Console.WriteLine($"Side: {side.Key}, Members: {side.Value}");
    }

    foreach (var forceUser in forceUsers.Where(x => x.Value == side.Key).OrderBy(x => x.Key))
    {
        Console.WriteLine($"! {forceUser.Key}");
    }

}