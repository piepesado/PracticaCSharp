using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class EmpresaSueldos
    {
        public static void Main (String[] args)
        {
            int n; //cantidad de empleados
            float sueldo, sueldosTotal;
            int sumaMenor, sumaMayor;
            int x = 1; // contador del while
            sumaMenor = 0;
            sumaMayor = 0;
            sueldosTotal = 0;

            Console.WriteLine("A cuántos empleados les ingresará el sueldo?");
            n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                Console.WriteLine("Ingrese sueldo del empleado:");
                sueldo = float.Parse(Console.ReadLine());

                if (sueldo >= 100 && sueldo <= 300)
                {
                    sumaMenor = sumaMenor + 1;
                }
                if (sueldo > 300)
                {
                    sumaMayor = sumaMayor + 1;
                }
                sueldosTotal = sueldosTotal + sueldo;
                x = x + 1;
            }
            Console.WriteLine("La cantidad que ganan entre 100 y 300 es de " + sumaMenor + " empleado/s");
            Console.WriteLine("La cantidad que ganan más de 300 es de " + sumaMayor + " empleado/s");
            Console.WriteLine("La empresa invierte un total de " + sueldosTotal + " pesos en sueldos");
            Console.ReadKey();
        }
    }
}
