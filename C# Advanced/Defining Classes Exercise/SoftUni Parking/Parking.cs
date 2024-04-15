using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking( int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
            Count = 0;
        }

        public int Count { get; private set; }
        public List<Car> Cars { get; set; }
        public int Capacity { get; }
        

        public string AddCar(Car car)
        {
            if (Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Count >= Capacity)
            {
                return "Parking is full!";
                
            }

            Cars.Add(car);
            Count++;
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!Cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            Cars.Remove(GetCar(registrationNumber));
            Count--;
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    return car;
                }
            }

            return null;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var number in RegistrationNumbers)
            {
                RemoveCar(GetCar(number).RegistrationNumber);
            }
        }


    }
}
