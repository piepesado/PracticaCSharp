using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class FechaNavidad
    {
        public static void Main (String[] args)
        {
            int dia, mes;

            Console.WriteLine("Ingrese día:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes:");
            mes = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("Es Navidad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No corresponde a navidad");
                Console.ReadLine();
            }
        }
    }
}
