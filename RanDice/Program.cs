using System;
using System.Runtime.InteropServices;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            int sum = 0;

            Random r = new Random(s);

            for (int x = 0; x < n; x++)
            {
                sum += r.Next(1,7);
            }

            Console.WriteLine(sum);
        }
    }
}
