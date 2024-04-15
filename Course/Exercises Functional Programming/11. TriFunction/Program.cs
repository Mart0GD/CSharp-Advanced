

using System.Linq;

int treshold = int.Parse(Console.ReadLine());

string[] strings = Console.ReadLine().Split();

Func<string, int, bool> tresholdChecker = (str, treshold) => str.Sum(x => x) >= treshold ? true : false;

Func<string[], int, Func<string, int, bool>, string> firstFound = (strings, treshold, func) => strings.FirstOrDefault(str => func(str, treshold));
//{
//	foreach (var str in strings)
//	{
//		if (func(str, treshold))
//		{
//			return str;
//		}
//	}

//	return null;
//};

Console.WriteLine(firstFound(strings,treshold,tresholdChecker));


