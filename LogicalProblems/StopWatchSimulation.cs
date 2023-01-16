using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalProblems
{
    internal class StopWatchSimulation
    {
        public void stopwatch()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + "\n");
            }
            watch.Stop();
            Console.WriteLine($"Execution time :{watch.ElapsedMilliseconds} ms");
        }
    }
}
