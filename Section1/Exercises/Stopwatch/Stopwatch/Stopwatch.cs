using System;

namespace Stopwatch
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void start()
        {
            if (_isRunning)
                throw new InvalidOperationException(" Stopwatch is already running.please stop before starting a new one.");

            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }
        public void stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch has not been started. Please start the stopwatch before stopping it");

            _stopTime = DateTime.Now;
            _isRunning = false;
            Console.WriteLine("Stopwatch stopped.");
        }
        public TimeSpan GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is still running. Please stop it before counting the  duration.");

            return _stopTime - _startTime;
        }
    }
}
