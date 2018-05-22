using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyStopWatchApp.UnitTests
{
    [TestClass]
    public class StopwatchUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Start_CallStartWhenStopwatchRunning_ThrowsException()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sw.Start();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Stop_CallStopWhenStopwatchNotRunning_ThrowsException()
        {
            Stopwatch sw = new Stopwatch();
            sw.Stop();
        }

        [TestMethod]
        public void Start_StopAfterOneSecond_ConfirmDurationIsOneSecond()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(1000);
            sw.Stop();

            Assert.AreEqual(1, Convert.ToInt32(sw.Duration.TotalSeconds));
        }
    }
}
