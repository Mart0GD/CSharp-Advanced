

double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

Dictionary<double, int> seenNumbers = new Dictionary<double, int>();

for (int i = 0; i < numbers.Length; i++)
{
	if (!seenNumbers.ContainsKey(numbers[i]))
	{
		seenNumbers.Add(numbers[i], 0);
	}

	seenNumbers[numbers[i]]++;
}

foreach (var (number,times) in seenNumbers)
{
	Console.WriteLine($"{number} - {times} times");
}