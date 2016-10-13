using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Notas
    {
        public static void Main(String[] args)
        {
            int nota1, nota2, nota3;
            double promedio;

            Console.WriteLine("Ingrese la primera nota:");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota");
            nota3 = int.Parse(Console.ReadLine());

            promedio = ((nota1 + nota2 + nota3) / 3);

            if (promedio >= 7)
            {
                Console.WriteLine("Alumno aprobado");
                Console.ReadLine();
            }else
            {
                Console.WriteLine("Alumno no aprobado");
                Console.ReadLine();
            }      
        }
    }
}
