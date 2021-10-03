using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex93
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "aaa", "bbb", "ccc" };
            IEnumerable<string> WordCollection = words;

            foreach (string item in WordCollection)
                Console.WriteLine(item);
        }
    }
}