using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class AlumnosNotas
    {
        public static void Main(String[] args)
        {
            int nota, notaMayor, notaMenor;
            int x = 1;
            notaMayor = 0;
            notaMenor = 0;

            while (x <= 10)
            {
                Console.WriteLine("Ingrese la nota del almuno:");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    notaMayor = notaMayor + 1;
                }
                if (nota < 7)
                {
                    notaMenor = notaMenor + 1;
                }
                x = x + 1;
            }
            Console.WriteLine("Existen " + notaMayor + " alumnos con notas de 7 para arriba.");
            Console.WriteLine("Existen " + notaMenor + " alumnos con notas de 7 para abajo.");
            Console.ReadKey();   
        }
    }
}
