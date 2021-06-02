// cs_foreach.cs
using System;

namespace Foreach_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Fibarrray = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int i in Fibarrray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
