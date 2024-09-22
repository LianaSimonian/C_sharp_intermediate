using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.start();
            Thread.Sleep(2000);
            stopwatch.stop();
            Console.WriteLine("Duration : "+ stopwatch.getDuration());

            try
            {
                stopwatch.start();
                stopwatch.start();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                stopwatch.stop();
                stopwatch.stop();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            stopwatch.start();
            Console.WriteLine("Duration: " + stopwatch.getDuration());
            stopwatch.stop(); 
        }
    }
}