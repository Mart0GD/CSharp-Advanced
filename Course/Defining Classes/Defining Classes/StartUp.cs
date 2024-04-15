
using System.Text;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();

            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                List<Tuple<int, double>> currentTires = new();

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens.Length - 1; i += 2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1]);

                    currentTires.Add(new Tuple<int, double>(year, pressure));
                }

                List<Tire> currentTireComplect = new();

                foreach (var pair in currentTires)
                {
                    currentTireComplect.Add(new Tire(pair.Item1, pair.Item2));
                }

                tires.Add(currentTireComplect.ToArray());
            }

            string input2;
            List<Engine> engines = new();
            while ((input2 = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int hp = int.Parse(tokens[0]);
                double capacity = double.Parse(tokens[1]);

                engines.Add(new Engine(hp, capacity));
            }

            string input3;
            List<Car> cars = new();
            while ((input3 = Console.ReadLine()) != "Show special")
            {
                string[] tokens = input3.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);


                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

                cars.Add(car);
            }


            foreach (var car in cars.Where(x => x.Year >= 2017 
                                        && x.Engine.HorsePower > 330 
                                        && x.SummedPressure > 9
                                        && x.SummedPressure < 10))
            {
                car.Drive(20.0);
                // Console.WriteLine(car.WhoAmI());

                Console.WriteLine($"Make: {car.Make}");

                Console.WriteLine($"Model: {car.Model}");

                Console.WriteLine($"Year: {car.Year}");

                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");

                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }

    
}
