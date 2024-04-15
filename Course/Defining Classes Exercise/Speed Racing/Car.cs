
namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerkKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerkKilometer = fuelConsumptionPerkKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerkKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            if (Model == null) return;

            if (distance * FuelConsumptionPerkKilometer > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            FuelAmount -= distance * FuelConsumptionPerkKilometer;
            TravelledDistance += distance;
        }
    }
}


