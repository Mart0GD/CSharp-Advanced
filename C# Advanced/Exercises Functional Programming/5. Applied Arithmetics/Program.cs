


List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;
while ((command = Console.ReadLine()) != "end")
{
	if (command == "print")
	{
		Console.WriteLine(string.Join(" ", numbers));
	}
	else
	{
        numbers = DoArithmetics(numbers, command)(numbers);

	}


}

Func<List<int>, List<int>> DoArithmetics(List<int> numbers, string command)
{
    switch (command)
    {
        case "add":
            return numbers => numbers.Select(x => x + 1).ToList();
        case "multiply":
            return numbers => numbers.Select(x => x * 2).ToList();
            break;
        case "subtract":
            return numbers => numbers.Select(x => x - 1).ToList();
            break;


    }

    return null;
}
