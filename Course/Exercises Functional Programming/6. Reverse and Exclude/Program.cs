
Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};

Func<List<int>, int, List<int>> exclude = (numbers, divider) =>
{
    List<int> ints = new();

    for(int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % divider == 0)
        {
            continue;
        }

        ints.Add(numbers[i]);
    }

    return ints;
};


List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int divider = int.Parse(Console.ReadLine());

numbers = exclude(numbers, divider);
numbers = reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));
