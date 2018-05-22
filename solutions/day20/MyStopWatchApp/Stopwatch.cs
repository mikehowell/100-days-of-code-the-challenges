using System;

namespace MyStopWatchApp
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public TimeSpan Duration { get; private set; }

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("The stopwatch is already running");
            }

            _isRunning = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("The stopwatch is not running");
            }

            _isRunning = false;
            _stopTime = DateTime.Now;
            CalculateDuration();
        }

        private void CalculateDuration()
        {
            Duration = _stopTime - _startTime;
            Console.WriteLine(Duration);
        }
    }
}
