using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Digitos
    {
        public static void Main (String[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero para comprobar si tiene uno o dos digitos:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 99)
            {
                Console.WriteLine("El numero ingresado tiene dos digitos.");
                Console.ReadLine();
            } if (numero <10)
            {
                Console.WriteLine("El numero ingresado tiene un digito.");
                Console.ReadLine();
            } if (numero >= 100 && numero <1000)
            {
                Console.WriteLine("El numero ingresado tiene tres digitos");
                Console.ReadLine();
            }
        }
    }
}
