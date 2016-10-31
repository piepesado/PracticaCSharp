using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class SumaHasta9999
    {
        public static void Main (String[] args)
        {
            int suma, valor;
            suma = 0;

            Console.WriteLine("Ingrese números para sumarlos. Sale ingresando 9999");
            do
            {                
                valor = int.Parse(Console.ReadLine());
                if (valor != 9999)
                {
                    suma = suma + valor;
                }
                
            } while (valor != 9999);
            Console.WriteLine("El valor de la suma es: " + suma);
            if (suma > 0)
            {
                Console.WriteLine("La suma es mayor a cero");
                Console.ReadKey();
            }
            else
            {
                if (suma == 0)
                {
                    Console.WriteLine("La suma es igual a cero");
                    Console.ReadKey();
                }
                else
                {
                    if (suma < 0)
                    {
                        Console.WriteLine("La suma es menor a cero");
                        Console.ReadKey();
                    }
                }
            }

        }
    }
}
