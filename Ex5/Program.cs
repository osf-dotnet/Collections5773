using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(12);
            array.Add("oshri");
            array.Add(21.34);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            int x = (int)array[1] * 2;

        }
    }
}
