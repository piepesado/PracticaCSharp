using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CondicionalAnidada
    {
        public static void Main(String[] args)
        {
            int nota1, nota2, nota3;
            double promedio;

            Console.WriteLine("Ingrese la 1er nota:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la 2da nota:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la 3era nota:");
            nota3 = int.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Aprobado");
                Console.ReadLine();
            }
            else
            {
                if (promedio >= 4)
                {
                    Console.WriteLine("Regular");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Reprobado");
                    Console.ReadLine();
                }
            }           
        }
    }
}
