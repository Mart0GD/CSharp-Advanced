

int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

Func<int, bool> getEven = GetEven;

Predicate<int> evens = GetEven;

Console.WriteLine(string.Join(", ", numbers.Where(x => evens(x)).OrderBy(x => x)));


bool GetEven(int number)
{
	return number % 2 == 0;
}