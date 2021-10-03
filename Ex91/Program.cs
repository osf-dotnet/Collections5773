using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex91
{
    class Program
    {
        public static IEnumerable f2()
        {
            Random r = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                int x = r.Next(20);
                Console.WriteLine(x);
                list.Add(x);
            }
            return list;
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
