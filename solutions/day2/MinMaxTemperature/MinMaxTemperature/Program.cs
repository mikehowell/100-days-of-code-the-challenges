using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] temperatures = new float[] { 10.0f, 11.3f, 4.5f, -2.0f, 3.6f, -3.3f, 0.0f };
            var CheckTemp = new Temperature();
            CheckTemp.CheckTemperature(temperatures);

            Console.WriteLine("Max Temp: {0} \r\nMin Temp: {1}", CheckTemp.MaxTemp, CheckTemp.MinTemp);
        }
    }
}
