using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UjjwalaProgram
{
    class Stopwatch
    {
        DateTime StartTime;
        DateTime StopTime;
        Boolean IsRunning;

        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Cannot start : Already Running");
            }

            StartTime = DateTime.Now;
            IsRunning = false;

        }

        public void Stop()
        {
            if(!IsRunning)
            {
                throw new InvalidOperationException("Cannot Stop : Not Running");
                
            }

            
            StopTime = DateTime.Now;
            IsRunning = true;
        }

        public TimeSpan ElapsedTime()
        {
            if(IsRunning)
            {
                return DateTime.Now - StartTime;
            }

            else
            {
                return StopTime - StartTime;
            }
        }
        static void Main(string[] args)
        {
            var Stopwatch = new Stopwatch();
            int choice;

            do
            {
                Console.WriteLine("1-Start Timer \n 2- stop Timer \n 3-Read Timer \n 0- Quit \n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Stopwatch.Start(); break;
                    case 2: Stopwatch.Stop(); break;
                    case 3: Console.WriteLine(Stopwatch.ElapsedTime()); break;
                }

            } while (choice != 0);

            
        }
    }
}
