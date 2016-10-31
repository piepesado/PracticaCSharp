using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class DoWhileCargaPromedio
    {
        public static void Main(String[] args)
        {
            int valor, promedio, suma, cantidad;
            suma = 0;
            cantidad = 0;

            do
            {
                Console.WriteLine("Ingrese valores, se calculará su promedio, para salir ingrese el valor 0");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
                cantidad++;
                promedio = suma / cantidad;
            } while (valor != 0);
            Console.WriteLine("El promedio de los valores ingresados es: " + promedio + ".");
            Console.ReadKey();
        }
    }
}
