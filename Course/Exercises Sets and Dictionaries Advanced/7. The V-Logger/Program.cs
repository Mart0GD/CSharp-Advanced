

Dictionary<string, Vloger> vlogersInfo = new();

string command;
while ((command = Console.ReadLine()) != "Statistics")
{
    string[] tokens = command.Split();

    string vlogerName = tokens.First();
    string action = tokens[1];

    if (action == "joined" && !vlogersInfo.ContainsKey(vlogerName))
    {
        vlogersInfo.Add(vlogerName, new Vloger(vlogerName, 0, 0, new List<string>(), new List<string>()));
    }
    else if (action == "followed" 
            && vlogersInfo.ContainsKey(vlogerName) 
            && vlogersInfo.ContainsKey(tokens.Last()) 
            && vlogerName != tokens.Last()
            && !vlogersInfo[vlogerName].followingNames.Contains(tokens.Last())
            )
    {
        string secondVlogerName = tokens.Last();

        vlogersInfo[vlogerName].followingNames.Add(secondVlogerName);
        vlogersInfo[vlogerName].following++;

        vlogersInfo[secondVlogerName].followersNames.Add(vlogerName);
        vlogersInfo[secondVlogerName].followers++;
    }
}


Console.WriteLine($"The V-Logger has a total of {vlogersInfo.Count} vloggers in its logs.");

var mostFollowed = vlogersInfo.OrderByDescending(x => x.Value.followers).ThenBy(x => x.Value.following).FirstOrDefault().Key;

foreach (var vloger in vlogersInfo.Where(x => x.Key == mostFollowed))
{
    Console.WriteLine($"1. {mostFollowed} : {vloger.Value.followers} followers, {vloger.Value.following} following");
    
    foreach (var follower in vloger.Value.followersNames.OrderBy(x => x))
    {
        Console.WriteLine($"*  {follower}");
    }
}


int number = 2;
foreach (var vloger in vlogersInfo.OrderByDescending(x => x.Value.followers).ThenBy(x => x.Value.following).Skip(1))
{
    Console.WriteLine($"{number}. {vloger.Key} : {vloger.Value.followers} followers, {vloger.Value.following} following");
    number++;
}


class Vloger
{
    public Vloger(string name, int followers, int following, List<string> followersNames, List<string> followingNames)
    {
        Name = name;
        this.followers = followers;
        this.following = following;
        this.followersNames = followersNames;
        this.followingNames = followingNames;
    }

    public string Name { get; set; }

    public int followers { get; set; }

    public int following { get; set; }

    public List<string> followersNames { get; set; } = new List<string>();

    public List<string> followingNames { get; set; } = new List<string>();

}