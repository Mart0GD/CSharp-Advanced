using System.Linq;

Queue<string> songs = new(Console.ReadLine().Split(", "));



while (songs.Any())
{
    string[] command = Console.ReadLine().Split();
    string commandName = command.First();

    if (commandName == "Play")
    {
        songs.Dequeue();
    }
    else if (commandName == "Add")
    {
        string song = string.Join(" ", command.Skip(1));

        if (!songs.Contains(song))
        {
            songs.Enqueue(song);
            continue;
        }
   
        Console.WriteLine($"{song} is already contained!");
    }
    else if (commandName == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
}

Console.WriteLine("No more songs!");
