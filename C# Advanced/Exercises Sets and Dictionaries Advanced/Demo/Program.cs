

Dictionary<string, string> contests = new();

string command;
while ((command = Console.ReadLine()) != "end of contests")
{
    string[] tokens = command.Split(":");

    string contest = tokens.First();
    string pass = tokens.Last();

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, pass);
    }
}

Dictionary<string, Dictionary<string, int>> users = new();

while ((command = Console.ReadLine()) != "end of submissions")
{
    string[] tokens = command.Split("=>");

    string contest = tokens.First();
    string pass = tokens[1];
    string username = tokens[2];
    int points = int.Parse(tokens[3]);

    if (contests.ContainsKey(contest) && contests[contest] == pass)
    {
        if (!users.ContainsKey(username))
        {
            users.Add(username, new Dictionary<string, int>());
        }
        else
        {
            if (users[username][contest] < points)
            {
                users[username][contest] = points;
            }

            continue;
        }
        
        users[username].Add(contest, points);

    }
}

   ;


class User
{
    public User(string name, Dictionary<string, int> contests)
    {
        Name = name;
        Contests = contests;
    }

    public string Name { get; set; }
    public Dictionary<string, int> Contests { get; set; }


}