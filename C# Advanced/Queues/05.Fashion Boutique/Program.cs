
Stack<int> clothes = new(Console.ReadLine().Split().Select(int.Parse));

int rackCapacity = int.Parse(Console.ReadLine());

int racks = 1;
int currentRackCapacity = rackCapacity;

while (clothes.Any())
{
    int currentClothesValue = clothes.Peek();

	if (currentRackCapacity - currentClothesValue < 0)
	{
		currentRackCapacity = rackCapacity;
		racks++;
		continue;
	}

	clothes.Pop();
	currentRackCapacity -= currentClothesValue;
}

Console.WriteLine(racks);