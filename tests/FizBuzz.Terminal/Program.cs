using System;
using static FizzBuzz.Core.FizzBuzz;

namespace FizBuzz.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetFizzBuzz(10)
            int i = 1;
            foreach (var item in GetFizzBuzz(20))
            {
                Console.WriteLine($"[{i++}] = {item}");
            }
        }
    }
}
