using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class ForPractice
    {
        public static void Main (String[] args)
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("-");             
            }
            Console.ReadKey();
        }
    }
}
