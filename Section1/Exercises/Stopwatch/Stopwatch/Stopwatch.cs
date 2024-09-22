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
                throw new InvalidOperationException("Stopwatch is already running,you need to stop it before starting!");
            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started !");
        }
        public void stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch has not been started,you need to start it before stopping!");
            _stopTime = DateTime.Now;
            _isRunning = false;
            Console.WriteLine("Stopwatch stopped !");
        }
        public TimeSpan getDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is still running,you need to stop it before calculating the  duration !");
            return _stopTime - _startTime;
        }

    }
}