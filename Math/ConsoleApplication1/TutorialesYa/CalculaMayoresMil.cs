using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CalculaMayoresMil
    {
        public static void Main(String[] args)
        {
            int x;
            int n = 0;
            int mayorMil = 0;
            int valor = 0;

            Console.WriteLine("Ingrese cuanto valores cargará para informar cuantos son mayores iguales a mil:");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                Console.WriteLine("Ingrese valor:");
                valor = int.Parse(Console.ReadLine());
                if (valor >= 1000)
                {
                    mayorMil = mayorMil + 1;
                }
            }
            Console.WriteLine("Se ingresaron " + mayorMil + " valores mayores o iguales a 1000");
            Console.ReadKey();
        }
    }
}
