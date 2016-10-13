using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Operario
    {
        public static void Main(String[] args)
        {
            double sueldo;
            int añosAntiguedad;

            Console.WriteLine("Ingresar sueldo del operario:");
            sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar años de antiguedad:");
            añosAntiguedad = int.Parse(Console.ReadLine());

            if (sueldo < 500 && añosAntiguedad >= 10)
            {
                sueldo = sueldo * 1.20;
                Console.WriteLine("El sueldo del operario a aumentado a: $" + sueldo);
                Console.ReadLine();
            }
            else
            {
                if (sueldo < 500 && añosAntiguedad < 10)
                {
                    sueldo = sueldo * 1.05;
                    Console.WriteLine("El sueldo del operario a aumentado a: $" + sueldo);
                    Console.ReadLine();
                }
                else
                {
                    if (sueldo >= 500)
                    {
                        Console.WriteLine("El sueldo no aumenta, sigue siendo de: $ " + sueldo);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
