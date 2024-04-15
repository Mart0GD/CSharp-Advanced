int pumpsCount = int.Parse(Console.ReadLine());

Queue<Pump> pumps = new Queue<Pump>();

for (int i = 0; i < pumpsCount; i++)
{
    int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();

    pumps.Enqueue(new Pump(pump[0], pump[1]));
}

int firstPumpIndex = 0;

for (int i = 0; i < pumpsCount; i++)
{
    Queue<Pump> pumpsforRotation = new(pumps);
    int currentFuel = 0;
    bool success = true;

    for (int j = 0; j < pumpsCount; j++)
    {
        Pump currentPump = pumpsforRotation.Peek();

        currentFuel += currentPump.petrol;

        if (currentFuel < currentPump.distance)
        {
            success = false;
            break;
        }

        currentFuel -= currentPump.distance;
        pumpsforRotation.Enqueue(pumpsforRotation.Dequeue());
    }

    if (success)
    {
        firstPumpIndex = i;
        break;
    }

    pumps.Enqueue(pumps.Dequeue());
}

Console.WriteLine(firstPumpIndex);

class Pump
{
    public Pump(int petrol, int distance)
    {
        this.petrol = petrol;
        this.distance = distance;
    }

    public int petrol { get; set; }
    public int distance { get; set; }
}
