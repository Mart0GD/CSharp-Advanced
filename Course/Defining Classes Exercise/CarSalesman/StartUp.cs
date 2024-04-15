

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new();
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(engineInfo[0],
                                           int.Parse(engineInfo[1]),
                                           engineInfo.Length - 1 >= 2 && int.TryParse(engineInfo[2], out int intResult) ? intResult : null,
                                           engineInfo.Length - 1 >= 2 && !int.TryParse(engineInfo.Last(), out int stringResult) ? engineInfo.Last(): null);

                engines.Add(engine);
            }

            int carLines = int.Parse(Console.ReadLine());

            List<Car> cars = new();
            for (int i = 0; i < carLines; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                                  carInfo[0],
                                  engines.Where(x => x.Model == carInfo[1]).FirstOrDefault(),
                                  carInfo.Length - 1 >= 2 && int.TryParse(carInfo[2], out int result) ? result : null,
                                  carInfo.Length - 1 >= 2 && !int.TryParse(carInfo.Last(), out int stringResult) ? carInfo.Last() : null
                                  );

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}

