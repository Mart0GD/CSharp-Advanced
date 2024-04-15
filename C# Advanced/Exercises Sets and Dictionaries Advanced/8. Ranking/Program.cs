

using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

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
        else if (users[username].ContainsKey(contest))
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

int sum = users.Max(x => x.Value.Sum(x => x.Value));
string name = users.Single(x => x.Value.Values.Sum() == sum).Key;

Console.WriteLine($"Best candidate is {name} with total {sum} points.");

Console.WriteLine("Ranking:");

foreach (var user in users.OrderBy(x => x.Key))
{
    Console.WriteLine($"{user.Key}");

    foreach (var contest in user.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}
