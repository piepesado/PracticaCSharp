using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExplicitConversion
    {
        static void Main(String[] args)
        {
            double d = 1274.97;
            int i;

            //convertir double a int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
