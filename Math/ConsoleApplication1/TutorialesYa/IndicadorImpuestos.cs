using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class IndicadorImpuestos
    {
        public static void Main (String[] args)
        {
            double sueldo;

            Console.WriteLine("Ingrese el sueldo:");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Debe abonar impuestos");
            }
            Console.ReadKey();
        }        
    }
}
