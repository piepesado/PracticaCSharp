using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class MuestraUltimos5
    {
        public static void Main (String[] args)
        {
            int x;
            int cantidad = 0;
            int valor;

            Console.WriteLine("Ingrese 10 valores:");

            for (x = 0; x < 10; x++)
            {
                valor = int.Parse(Console.ReadLine());
                if (x >= 5)
                {
                    cantidad = cantidad + valor;
                }
            }
            Console.WriteLine("La suma de los últimos 5 números resulta en: " + cantidad);
            Console.ReadKey();
        }
    }
}
