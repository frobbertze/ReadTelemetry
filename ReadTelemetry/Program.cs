using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ReadTelemetry
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = 0;
            while (count < 90000000000)
            {


                var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                Console.Write(cpuCounter.NextValue() + "%");
                Console.WriteLine();
                Console.Write(ramCounter.NextValue() + "MB");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                count++;
            }

            Console.ReadLine();

        }
    }
}
