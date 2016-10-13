using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EnterNumbers : MethodsPractice
    {
        static void Main(String[] args)
        {
            int number;

            Console.WriteLine("Ingrese un nùmero del 15 al 30");
            number = int.Parse(Console.ReadLine());

            if ((number >= 15) && (number <= 30))
            {
                Console.WriteLine("Correcto!");
                Console.ReadLine();               
            }
            else
            {
                Console.WriteLine("Mal! El numero ingresado no es correcto");
                Console.ReadLine();
            }

            
        }
    }
}
