using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class RangoVariacion
    {
        public static void Main (String[] args)
        {
            int val1, val2, val3;

            Console.WriteLine("Ingrese el primer valor:");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            val2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor:");
            val3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Rango de valores:");
            Console.WriteLine("Menor");

            if (val1 < val2 && val1 < val3)
            {
                Console.WriteLine(val1);
            }else
            {
                if (val2 < val3)
                {
                    Console.WriteLine(val2);
                }else
                {
                    Console.WriteLine(val3);
                }
            }
            Console.WriteLine("Mayor");

            if (val1 > val2 && val1 > val3)
            {
                Console.WriteLine(val1);
            }else
            {
                if (val2 > val3)
                {
                    Console.WriteLine(val2);
                }else
                {
                    Console.WriteLine(val3);
                }
            }
            Console.ReadKey();
        }
    }
}
