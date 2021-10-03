using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex9
{
    class Program
    {
        public static IEnumerable f1()
        {
            yield return 2;
            Console.WriteLine("---");
            yield return 1;

            yield return 4;
            Console.WriteLine("+++");
            yield return 5;
        }

        static void Main(string[] args)
        {
            IEnumerable en = f1();

            foreach (int item in en)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);


            }
        }

    }
}
