using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringConversion
    {
        static void Main(String[] args)
        {
            int i = 33;
            float f = 55.00f;
            double d= 147.91;
            bool b = true;

            Console.WriteLine("int to string: " + i.ToString());
            Console.WriteLine("float to string: " + f.ToString());
            Console.WriteLine("double to string " + d.ToString());
            Console.WriteLine("bool to string " + b.ToString());
            Console.ReadLine();
        }
    }
}
