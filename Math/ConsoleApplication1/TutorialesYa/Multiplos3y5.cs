using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Multiplos3y5
    {
        public static void Main (String[] args)
        {
            int mul3, mul5; //mul35;
            int x;
            int valor;
            mul3 = 0;
            mul5 = 0;
            //mul35 = 0;

            Console.WriteLine("Ingrese 10 números enteros:");

            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("Ingrese número entero:");
                valor = int.Parse(Console.ReadLine());
                if (valor % 3 == 0)
                {
                    mul3 = mul3 + 1;
                }
                if(valor % 5 == 0)
                {
                    mul5 = mul5 + 1;
                }
                //if (valor % 3 == 0 && valor % 5 == 0)
                //{
                //    mul35 = mul35 + 1;
                //}
            }
            Console.WriteLine("Se ingresaron " + mul3 + " multiplos de 3, " + mul5 + " multiplos de 5  " /*+ mul35 + " multiplos de 3 y 5."*/);
            Console.ReadKey();
        }
    }
}
