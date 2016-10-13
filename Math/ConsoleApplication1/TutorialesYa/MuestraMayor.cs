using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class MuestraMayor
    {
        public static void Main(String[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Ingrese numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El Numero 1 es el mayor");
                Console.ReadLine();
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                    Console.ReadLine();
                }
                else
                {
                    if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine("El numero 3 es el mayor");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
