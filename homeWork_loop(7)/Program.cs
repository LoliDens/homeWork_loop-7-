using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_loop_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCycle = 5;
            int endCycle = 96;
            int stepCycle = 7;

            for (int i = startCycle; i <= endCycle; i += stepCycle) 
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
