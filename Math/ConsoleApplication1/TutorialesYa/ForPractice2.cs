using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class ForPractice2
    {
        public static void Main (String[] args)
        {
            int valor, suma, i;
            float promedio;
            suma = 0;            

            Console.WriteLine("Los valores que ingrese serán sumados y su promedio efectuado");

            for ( i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese valor");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
            }
            promedio = suma / 10;
            Console.WriteLine("La suma de los 10 valores es: " + suma);
            Console.WriteLine("El promedio de los 10 valores es :" + promedio.ToString());
            Console.ReadKey();           
        }
    }
}
