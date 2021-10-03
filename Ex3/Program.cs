using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intArray = new int[4][];
            string[][][] stringArray = new string[4][][];
            object[][][][] objectArray = new object[4][][][];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new int[4];
                for (int j = 0; j < intArray[i].Length; j++)
                    intArray[i][j] = (i + 1) * (j + 1);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray[i].Length; j++)
                    Console.Write("{0,-3}", intArray[i][j]);
                Console.WriteLine();
            }


        }
    }
}
