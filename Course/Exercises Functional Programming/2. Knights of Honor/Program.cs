

List<string> names = Console.ReadLine().Split().ToList();

Action<List<string>> printEntitled = names => names.ForEach(x => Console.WriteLine($"Sir {x}"));

printEntitled(names);

