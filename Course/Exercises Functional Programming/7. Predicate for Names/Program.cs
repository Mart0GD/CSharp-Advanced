

Func<string, int, bool> filterNames = (name, length) => name.Length  <= length ? true : false;

int length = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();


foreach (string name in names)
{
	if (filterNames(name, length))
	{
		Console.WriteLine(name);
	}
}
