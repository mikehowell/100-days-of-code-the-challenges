using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinMaxTemperature.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckTemperature_SetsMaxAndMinTemperatureProperties()
        {
            float[] temperatures = new float[] { 10.0f, 11.3f, 4.5f, -2.0f, 3.6f, -3.3f, 0.0f };
            var CheckTemp = new Temperature();
            CheckTemp.CheckTemperature(temperatures);
            var expectedMinTemp = -3.3f;
            var expectedMaxTemp = 11.3f;

            Assert.AreEqual(expectedMinTemp, CheckTemp.MinTemp);
            Assert.AreEqual(expectedMaxTemp, CheckTemp.MaxTemp);
        }
    }
}
