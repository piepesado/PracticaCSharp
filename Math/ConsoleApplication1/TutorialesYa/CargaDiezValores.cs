using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CargaDiezValores
    {
        public static void Main (String[] args)
        {
            int num;            
            int suma = 0;
            decimal promedio;
            int x = 1;
            
            while (x <= 10)
            {
                Console.WriteLine("Ingrese un valor:");
                num = int.Parse(Console.ReadLine());
                x = x + 1;
                suma = suma + num;                
            }
            Console.WriteLine("El resultado de la suma de los 10 valores es: " + suma);
            promedio = suma / 10;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.ReadKey();
        }
    }
}
