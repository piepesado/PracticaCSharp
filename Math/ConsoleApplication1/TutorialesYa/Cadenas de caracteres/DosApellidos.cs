using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Cadenas_de_caracteres
{
    class DosApellidos
    {
        public static void Main(String[] args)
        {     

            string apellido1, apellido2;

            Console.WriteLine("Ingrese apellido N1:");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Ingrese apellido N2:");
            apellido2 = Console.ReadLine();
            if (apellido1 == apellido2)
            {
                Console.WriteLine("Los apellidos son iguales");
            }
            else
            {
                Console.WriteLine("Los apellidos son diferentes");
            }
            Console.ReadKey();
        }
    }
}
