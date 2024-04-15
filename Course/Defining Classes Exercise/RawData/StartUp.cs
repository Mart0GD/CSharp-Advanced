

using RawData;
using System;
using System.Collections.Concurrent;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                Cargo cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
                };

                Car car = new Car(carInfo[0], engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> result;
            if (command == "fragile")
            {
                 result = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1)).ToList();
            }
            else
            {
                result = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result.Select(x => x.Model)));
        }
    }
}