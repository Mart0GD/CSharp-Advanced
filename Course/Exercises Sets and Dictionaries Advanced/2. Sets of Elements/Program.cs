

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

HashSet<int> setOne = new();
HashSet<int> setTwo = new();

for (int i = 0; i < size[0]; i++)
{
    setOne.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < size[1]; i++)
{
    setTwo.Add(int.Parse(Console.ReadLine()));
}

setOne.IntersectWith(setTwo);

Console.WriteLine(string.Join(" ", setOne));