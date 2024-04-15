

Queue<int> cups = new(Console.ReadLine().Split().Select(int.Parse));
Stack<int> bottles = new(Console.ReadLine().Split().Select(int.Parse));

int wastedWater = 0;

while (cups.Any() && bottles.Any())
{
    int currentCup = cups.Peek();
    int currentBottle = bottles.Pop();

    int diff = currentBottle - currentCup;

    if ( diff >= 0)
    {
        cups.Dequeue();
        wastedWater += diff;
    }
    else if (diff < 0)
    {
        while (diff < 0 && bottles.Any())
        {
            diff += bottles.Pop();
        }

        if (diff >= 0)
        {
            wastedWater += diff;
            cups.Dequeue();
        }    
    }
}

if (cups.Count <= 0)
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
else
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
}
Console.WriteLine($"Wasted litters of water: {wastedWater}");