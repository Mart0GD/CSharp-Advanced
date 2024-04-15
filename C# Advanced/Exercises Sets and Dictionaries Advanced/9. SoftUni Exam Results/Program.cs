

Dictionary<string, int> userTests = new();

Dictionary<string, int> languageSubmissions = new();


string command;
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] tokens = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

    string username = tokens.First();

    if (tokens[1] == "banned")
    {
        userTests.Remove(username);

        continue;
    }

    string language = tokens[1];
    int points = int.Parse(tokens.Last());

    if (!languageSubmissions.ContainsKey(language))
    {
        languageSubmissions.Add(language, 0);
    }

    if (!userTests.ContainsKey(username))
    {
        userTests.Add(username, 0);
    }

    if (userTests[username] < points)
    {
        userTests[username] = points;
    }

    languageSubmissions[language]++;
}

Console.WriteLine("Results:");

foreach (var user in userTests.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{user.Key} | {user.Value}");

}

Console.WriteLine("Submissions:");

foreach (var language in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{language.Key} - {language.Value}");
}