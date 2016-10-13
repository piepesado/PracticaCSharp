using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class MenorDiez
    {
        public static void Main(String[] args)
        {
            int val1, val2, val3;

            Console.WriteLine("Ingrese primer valor:");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo valor:");
            val2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer valor:");
            val3 = int.Parse(Console.ReadLine());

            if (val1 < 10 || val2 < 10 || val3 < 10)
            {
                Console.WriteLine("Alguno de los valores es menor a diez");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ningun valor es menor a diez");
                Console.ReadLine();
            }
        }
    }
}
