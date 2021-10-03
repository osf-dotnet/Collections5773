using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[4, 4] 
            { 
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }, 
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 } 
            };

            Console.WriteLine(intArray[0, 3]);
            Console.WriteLine(intArray[3, 0]);

        }
    }
}