using System;
using System.Collections.Generic;
using System.Threading;

namespace Newstopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch instance = new StopWatch();
            instance.Start();
            Thread.Sleep(3000);
            instance.Stop();

            Console.WriteLine("Interval:" + instance.GetInterval());
            Console.ReadKey();

        }
    }

    public class StopWatch
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        bool IsStarted { get; set; }

        public void Start()
        {
            if(!IsStarted)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }
        }

        public void Stop()
        {
            if (IsStarted)
            {
                EndTime = DateTime.Now;
                IsStarted = false;
            }
        }

        public TimeSpan GetInterval()
        {
            return EndTime - StartTime;
        }

    }
}
