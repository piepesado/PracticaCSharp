using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class DosListas
    {
        public static void Main (String [] args)
        {
            int sumLista1, sumLista2;
            int valor1, valor2;
            int x = 1;
            int y = 1;
            sumLista1 = 0;
            sumLista2 = 0;

            Console.WriteLine("Ingrese 15 valores en la 1era lista:");
            
            while (x <= 15)
            {
                valor1 = int.Parse(Console.ReadLine());
                sumLista1 = sumLista1 + valor1;
                x = x + 1;
            }

            Console.WriteLine("Ingrese 15 valores de la 2da lista:");

            while (y <= 15)
            {
                valor2 = int.Parse(Console.ReadLine());
                sumLista2 = sumLista2 + valor2;
                y = y + 1;
            }
            if (sumLista1 > sumLista2)
            {
                Console.WriteLine("La lista 1 es mayor que la lista 2");
                Console.ReadKey();
            }
            if (sumLista1 < sumLista2)
            {
                Console.WriteLine("La lista 2 es mayor que la lista 1");
                Console.ReadKey();
            }
            if (sumLista1 == sumLista2)
            {
                Console.WriteLine("Las dos listas suman igual");
                Console.ReadKey();
            }            
        }
    }
}
