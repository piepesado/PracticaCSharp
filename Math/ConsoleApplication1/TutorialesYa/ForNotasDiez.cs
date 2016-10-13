using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class ForNotasDiez
    {
        public static void Main (String[] args)
        {
            int x;
            int aprobados = 0;
            int reprobados = 0;
            int nota;

            Console.WriteLine("Ingrese las 10 notas de alumnos:");

            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("Ingrese la nota del alumno:");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    aprobados = aprobados + 1;
                }
                else
                {
                    reprobados = reprobados + 1;
                }
            }
            Console.WriteLine("Se ingresaron " + aprobados + " alumnos aprobados y " + reprobados + " reprobados");
            Console.ReadKey();
        }
    }
}
