

int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());

Stack<int> bullets = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> locks = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int intelliganceValue = int.Parse(Console.ReadLine());

int usedBullets = 0;
while (bullets.Any() && locks.Any())
{ 

    int currentBullet = bullets.Pop();
    int currentLock = locks.Peek();

    if (currentBullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }
    usedBullets++;

    if (bullets.Any() && usedBullets % gunBarrelSize == 0)
    {
        Console.WriteLine("Reloading!");
    }
}


if (!bullets.Any() && locks.Any())
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelliganceValue - (usedBullets * bulletPrice)}");
}
