using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Alturas
    {
        public static void Main(String[] args)
        {
            int x = 1; //contador del while
            float altura, promedio;
            float suma = 0;
            int n; //cantidad de personas

            Console.WriteLine("Cuántas personas para ingresar alturas hay?");
            n = int.Parse(Console.ReadLine());

            while ( x <= n)
            {
                Console.WriteLine("Ingrese altura:");
                altura = float.Parse(Console.ReadLine());
                suma = suma + altura;
                x = x + 1;                
            }
            promedio = suma / n;
            Console.WriteLine("El promedio de alturas ingresadas es de " + promedio + " metros.");
            Console.ReadKey();
        }
    }
}
