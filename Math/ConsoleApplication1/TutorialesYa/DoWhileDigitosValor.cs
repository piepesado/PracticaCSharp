using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class DoWhileDigitosValor
    {
        public static void Main (String[] args)
        {
            int x;

            do
            {
                Console.WriteLine("Ingrese un número natural menor a 1000:");
                x = int.Parse(Console.ReadLine());
                if (x >= 100)
                {
                    Console.WriteLine("Se ingresó un valor de 3 dígitos");
                }
                else
                {
                    if (x >= 10 && x <= 99)
                    {
                        Console.WriteLine("Se ingresó un número de 2 dígitos");
                    }
                    else
                    {
                        Console.WriteLine("Se ingresó un número de 1 dígito");
                    }
                }

            } while (x != 0);        
            
        }
    }
}
