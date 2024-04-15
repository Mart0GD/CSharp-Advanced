

SortedDictionary<char, int> symbolsCount = new();

string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
	if (!symbolsCount.ContainsKey(input[i]))
	{
		symbolsCount.Add(input[i], 0);
	}

	symbolsCount[input[i]]++;
}

foreach (var _char in symbolsCount)
{
	Console.WriteLine($"{_char.Key}: {_char.Value} time/s");
}