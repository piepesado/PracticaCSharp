using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Cadenas_de_caracteres
{
    class MayorEdad
    {
        public static void Main(String[] args)
        {
            string nombre1, nombre2;
            int edad1, edad2;

            Console.WriteLine("Ingrese el nombre de la persona:");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona:");
            edad1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la persona:");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona:");
            edad2 = int.Parse(Console.ReadLine());

            if (edad2 > edad1)
            {
                Console.WriteLine("La persona mayor es " + nombre2);
                            }
            else
            {
                Console.WriteLine("la persona mayor es " + nombre1);               
            }
            Console.ReadKey();
        }
    }
}
