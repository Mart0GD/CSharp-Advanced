

Dictionary<string, Dictionary<string, int>> clothesByColor = new();

int inputs = int.Parse(Console.ReadLine());

for (int i = 0; i < inputs; i++)
{
    string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

    string color = tokens[0];
    string[] clothes = tokens.Skip(1).ToArray();

    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor.Add(color, new Dictionary<string, int>());
    }

    foreach (var pieceOfClothing in clothes)
    {
        if (!clothesByColor[color].ContainsKey(pieceOfClothing))
        {
            clothesByColor[color].Add(pieceOfClothing, 0);
        }

        clothesByColor[color][pieceOfClothing]++;
    }
}

string[] pieceOfClothingToFind = Console.ReadLine().Split().ToArray();

foreach (var color in clothesByColor)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var pieceOfClothing in color.Value)
    {
        if (color.Key == pieceOfClothingToFind[0] && pieceOfClothing.Key == pieceOfClothingToFind[1])
        {
            Console.WriteLine($"* {pieceOfClothing.Key} - {pieceOfClothing.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {pieceOfClothing.Key} - {pieceOfClothing.Value}");
        }
    }
}