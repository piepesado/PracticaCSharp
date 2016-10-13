using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class TresCifras
    {
        public static void Main(String[] args)
        {
            int numero;

            Console.WriteLine("Ingrese numero");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("El numero ingresado es de una cifra");
                Console.ReadLine();
            }
            else
            {
                if (numero >= 10 && numero <= 99)
                {
                    Console.WriteLine("El numero ingresado es de dos cifras");
                    Console.ReadLine();
                }
                else
                {
                    if (numero >= 100 && numero <= 999)
                    {
                        Console.WriteLine("El numero ingresado es de tres cifras");
                        Console.ReadLine();
                    }
                    else
                    {
                        if (numero >= 1000)
                        {
                            Console.WriteLine("Error");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}