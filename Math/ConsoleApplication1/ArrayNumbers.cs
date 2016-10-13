using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayNumbers
    {
        static void Main (String[] args)
        {
            //int [] numbers = new int[5] { 0, 4, 6, 7, 9 };
            int [] oNumbers = { 4, 33, 98, 74, 2 };

            Array.Sort(oNumbers);

            foreach (int i in oNumbers)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
