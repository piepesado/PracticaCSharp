using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Loops
{
    class DoLoop
    {
        static void Main(String[] args)
        {
            int number = 0;

            do
            {
                Console.WriteLine(number);
                
                number = (number + 1);
                
            } while (number < 5);
            Console.ReadLine();
        }
    }
}
