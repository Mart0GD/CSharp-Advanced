using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CarManufacturer;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        private string make;
        private int year;
        private string model;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;
        private double summedPressure;

       


        public void Drive(double distance)
        {
           // double result = fuelQuantity - (distance * (fuelConsumption / 100.0));

            fuelQuantity -= distance * (fuelConsumption / 100);
            //if (result >= 0)
            //{
                
            //}
            //else
            //{
            //    Console.WriteLine("Not enough fuel to perform this trip!");
            //}
        }

        public string WhoAmI()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Make: {Make}");
            builder.AppendLine($"Model: {Model}");
            builder.AppendLine($"Year: {Year.ToString()}");
            builder.AppendLine($"HorsePowers: {Engine.HorsePower.ToString()}");
            builder.AppendLine($"FuelQuantity: {FuelQuantity.ToString()}");

            return builder.ToString();
        }

        public double SummedPressure
        {
            get 
            {
                double sum = 0;
                foreach (var pressure in tires)
                {
                    sum += pressure.Pressure;
                }

                return sum;
            }
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

    }
}
