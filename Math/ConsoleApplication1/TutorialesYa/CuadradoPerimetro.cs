using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CuadradoPerimetro
    {
        public static void Main(String[] args)
        {
            float lado;
            float perimetro;

            Console.WriteLine("Ingrese el valor del lado del cuadrado:");
            lado = float.Parse(Console.ReadLine());
            perimetro = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.ReadLine();
        }
    }
}
