

using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

Queue<string> trafficJam = new();

int passedCars = 0;
while (command != "END")
{
	
	if (command != "green")
	{
		trafficJam.Enqueue(command);
		
		command = Console.ReadLine();
		continue;
	}

	if (trafficJam.Any())
	{
        Queue<char> car = new(trafficJam.Dequeue());
        string carName = string.Join("", car);

        for (int i = 0; i < greenLightDuration; i++)
        {
            if (car.Any())
            {
                car.Dequeue();
            }
            else if (trafficJam.Any())
            {
                car = new(trafficJam.Dequeue());
                carName = string.Join("", car);
                car.Dequeue();

                passedCars++;
            }
            else break;
        }

        if (car.Any())
        {
            for (int i = 0; i < freeWindowDuration; i++)
            {
                if (car.Any())
                {
                    car.Dequeue();
                }
                else break;
            }

            if (car.Any())
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{carName} was hit at {car.Dequeue()}.");
                return;
            }
        }

        passedCars++;
    }

	
    command = Console.ReadLine();
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");