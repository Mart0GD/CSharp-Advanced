using System.Reflection;

namespace RawData
{
    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int v1, string v2)
        {
            this.Weight = v1;
            this.Type = v2;
        }
    }
}