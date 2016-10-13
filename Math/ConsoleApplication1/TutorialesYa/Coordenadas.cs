using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Coordenadas
    {
        public static void Main (String[] args)
        {
            int x, y;

            Console.WriteLine("Ingrese coordenada X:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada Y:");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el 1er cuadrante");
                Console.ReadLine();
            }else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 2do cuadrante");
                    Console.ReadLine();
                }else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el 3er cuadrante");
                        Console.ReadLine();
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("El punto se encuentra en el 4to cuadrante");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
