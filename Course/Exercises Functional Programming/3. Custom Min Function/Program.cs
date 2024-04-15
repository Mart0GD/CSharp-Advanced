

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], int> minFunc = numbers =>
{
	int min = int.MaxValue;

	foreach (var number in numbers)
	{
		if (number < min)
		{
			min = number;
		}
	}

	return min;
};


Console.WriteLine(minFunc(numbers));

