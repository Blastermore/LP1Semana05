using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            float ts1 = crono1.ElapsedMilliseconds/1000f;
            float ts2 = crono2.ElapsedMilliseconds/1000f;


            Console.WriteLine($"Time Elapsed on crono1: {ts1:f3}");
            Console.WriteLine($"Time Elapsed on crono1: {ts2:f3}");

        }
    }
}
