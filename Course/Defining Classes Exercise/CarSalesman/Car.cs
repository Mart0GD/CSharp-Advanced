using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine myProperty, int? weight, string? color)
        {
            Model = model;
            Engine = myProperty;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string? Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Model + ":");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");
            sb.AppendLine($"    Displacement: {CheckNA(Engine.Displacement)}");
            sb.AppendLine($"    Efficiency: {CheckNA(Engine.Efficiency)}");
            sb.AppendLine($"  Weight: {CheckNA(this.Weight)}");
            sb.AppendLine($"  Color: {CheckNA(this.Color)}");

            return sb.ToString().TrimEnd();
        }

        string CheckNA<T>(T _object)
        {
            if (_object == null)
            {
                return "n/a";
            }

            return _object.ToString();
        }

    }
}
