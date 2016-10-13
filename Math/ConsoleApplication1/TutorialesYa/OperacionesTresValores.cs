using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class OperacionesTresValores
    {
        public static void Main (String[] args)
        {
            int val1, val2, val3, suma;

            Console.WriteLine("Ingrese primer valor:");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo valor:");
            val2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer valor:");
            val3 = int.Parse(Console.ReadLine());

            if (val1 == val2 && val1 == val3 && val2 == val3)
            {
                suma = val1 + val2;
                Console.WriteLine("La suma de los dos primeros valores resulta: " + suma);
                Console.WriteLine("Luego de multiplicar el resultado de la suma por el tercer valor resulta en: " + (suma * val3));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Los valores ingresados no son iguales");
                Console.ReadLine();
            }
        }
    }
}
