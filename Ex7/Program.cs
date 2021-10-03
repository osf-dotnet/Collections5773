using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> myList = new List<int> { 1, 2, 3, 4 };
            int[] arrInt = new int[] { 12, 23, 44, 55, 6 };
            //IEnumerable arr = myList;
            IEnumerator enumerator = myList.GetEnumerator();
            arrInt[0] = 33;
            
            while (enumerator.MoveNext())
            {               
                int item = (int)enumerator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
