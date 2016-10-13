using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class TabladelValor
    {
        public static void Main (String[] args)
        {
            int x, valor;            

            Console.WriteLine("Ingrese un valor del 1 al 10");
            valor = int.Parse(Console.ReadLine());

            for (x = valor; x < valor * 12; x = x + valor)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
