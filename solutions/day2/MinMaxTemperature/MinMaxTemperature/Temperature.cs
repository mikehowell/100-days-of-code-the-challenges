using System;
using System.Linq;

namespace MinMaxTemperature
{
    public class Temperature
    {
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }

        public void CheckTemperature (float[] t)
        {
            this.MaxTemp = t.Max();
            this.MinTemp = t.Min();
        }
    }
}
