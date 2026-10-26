using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Array:IOutput2
    {
        int[] arr = [1, 2, 3, 6, 8,7,10,15,12,35];

        public void ShowEvent()
        {
            Console.WriteLine("Even elements are:");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd elements in the array are:");
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
