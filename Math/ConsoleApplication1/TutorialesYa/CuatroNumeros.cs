using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CuatroNumeros
    {
        public static void Main (String[] args)
        {
            int num1, num2, num3, num4, suma, producto;

            Console.WriteLine("Ingrese el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero:");
            num4 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine(suma);
            producto = num3 * num4;
            Console.WriteLine(producto);
            Console.ReadLine();
        }
    }
}
