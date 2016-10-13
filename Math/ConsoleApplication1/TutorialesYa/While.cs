using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class While
    {
        public static void Main (String[] args)
        {
            int x = 2;

            while (x <= 100)
            {
                Console.WriteLine(x);                
                x = x + 2;
            }
            Console.ReadKey();
        }
    }
}
