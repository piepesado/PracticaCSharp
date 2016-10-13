using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class SumaPromedio
    {
        public static void Main (String[] args)
        {
            float num1, num2, num3, num4, suma, promedio;

            Console.WriteLine("Ingrese el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero:");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma de los numeros es:" + suma);
            promedio = suma / 4;
            Console.WriteLine("El promedio de los numeros es: " + promedio);
            Console.ReadLine();
        }
    }
}
