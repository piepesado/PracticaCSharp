using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Loops
{
    class WhileLoop
    {
        static void Main(String[] args)
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = (number + 1);
            }
            Console.ReadLine();
        }
    }
}
