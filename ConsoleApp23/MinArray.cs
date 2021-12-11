using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class MinArray
    {
        int[] arr = { 10, 18, 27, 2, 100, 0, -5, 77, -24, 99 };
        public void checkarray()
        {
            int min = arr.Min();
            int index = Array.IndexOf(arr, min);
            Console.WriteLine($"min={min}");
            Console.WriteLine($"index={index}");
        }
    }
}
