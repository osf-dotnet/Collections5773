using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex92
{
    class Program
    {
        public static IEnumerable f2()
        {
            Random r = new Random();
            for (int i = 0; i < 40; i++)
            {
                int x = r.Next(20);
                Console.WriteLine(x);
                yield return x;
            }
        }

        static void Main(string[] args)
        {
            foreach (int item in f2())
            {
                if (item == 12)
                    break;
            }

        }
    }
}
