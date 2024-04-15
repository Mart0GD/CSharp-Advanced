

string[] strings = Console.ReadLine().Split();

Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

print(strings);