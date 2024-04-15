

using System.Diagnostics.CodeAnalysis;

int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


Func<int[], int> count = Count;
Func<int[], int> sum = Sum;

Console.WriteLine(count(numbers));
Console.WriteLine(sum(numbers));

int Count(int[] numbers)
{
	int sum = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		sum++;
	}

	return sum;
}

int Sum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum;
}