using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class WhileUser
    {
        public static void Main (String[] args)
        {
            int x = 1;
            int num;

            Console.WriteLine("Se contará desde 1 hasta el valor que ingrese:");
            num = int.Parse(Console.ReadLine());

            while ( x <= num)
            {
                Console.WriteLine(x);
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
