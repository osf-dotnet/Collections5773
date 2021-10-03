using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[4];
            int size = intArray.Length;
            for (int i = 0; i < size; i++)
            {
                intArray[i] = i * 2;
            }

        }
    }
}
