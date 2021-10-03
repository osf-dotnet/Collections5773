using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intArray = new int[4][] 
            { 
                new int[4]{ 1, 2, 3, 4 },
                new int[4]{ 5, 6, 7, 8 }, 
                new int[4]{ 9, 10, 11, 12 },
                new int[4]{ 13, 14, 15, 16 } 
            };

            Console.WriteLine(intArray[0][3]);
            Console.WriteLine(intArray[3][0]);

        }
    }
}
