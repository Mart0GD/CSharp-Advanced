

Dictionary<int, int> numbers = new();

int inputs = int.Parse(Console.ReadLine());

for (int i = 0; i < inputs; i++)
{
	int number = int.Parse(Console.ReadLine());

	if (!numbers.ContainsKey(number))
	{
		numbers.Add(number, 0);
	}

	numbers[number]++;
}

Console.WriteLine(numbers.Single(x => x.Value % 2 == 0).Key);