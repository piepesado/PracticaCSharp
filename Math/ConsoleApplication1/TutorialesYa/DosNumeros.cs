using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class DosNumeros
    {
        public static void Main(String[] args)
        {
            int numero1;
            int numero2;
            
            Console.WriteLine("Ingrese el primer numero:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("La suma de los dos numeros es: " + (numero1 + numero2));
                Console.WriteLine("La diferencia de los dos numeros es: " + (numero1 - numero2));
                Console.ReadLine();
            }else
            {
                Console.WriteLine("El producto de los dos numeros es: " + (numero1 * numero2));
                Console.WriteLine("La división de los dos numeros es: " + (numero1 / numero2));
                Console.ReadLine();
            }
        }
    }
}
