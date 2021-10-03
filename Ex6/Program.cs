using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(34);
            list.Add(25);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
