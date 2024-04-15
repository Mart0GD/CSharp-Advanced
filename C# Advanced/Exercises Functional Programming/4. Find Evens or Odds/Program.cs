

int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], List<int>> fillList = bounds =>
{
    List<int> result = new List<int>();

    for (int i = bounds[0]; i <= bounds[1]; i++)
    {
        result.Add(i);
    }

    return result;
};


List<int> numbers = fillList(bounds);

string condition = Console.ReadLine();

Predicate<string> printEvenOrOdd = condition => condition == "even" ? true : false;

for (int i = 0; i < numbers.Count; i++)
{
    if (printEvenOrOdd(condition) && numbers[i] % 2 == 0)
    {
        Console.Write(numbers[i] + " ");
    }
    else if (!printEvenOrOdd(condition) && numbers[i] % 2 != 0)
    {
        Console.Write(numbers[i] + " ");
    }
}

