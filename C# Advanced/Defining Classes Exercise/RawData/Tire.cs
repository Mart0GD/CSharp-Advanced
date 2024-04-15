namespace RawData
{
    public class Tire
    {

        public Tire(double v1, int v2)
        {
            Pressure = v1;
            Age = v2;
        }

        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}