
int foodQuantity = int.Parse(Console.ReadLine());

Queue<int> orders = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

Console.WriteLine(orders.Max());

while (orders.Count() > 0)
{
    int orderValue = orders.Peek();

	if (foodQuantity - orderValue < 0)
	{
		break;
	}

	foodQuantity -= orderValue;
	orders.Dequeue();
}


if (orders.Any())
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}
else
{
    Console.WriteLine("Orders complete");
}
