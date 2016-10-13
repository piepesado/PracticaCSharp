using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Trimestre
    {
        public static void Main(String[] args)
        {
            int dia, mes, año;

            Console.WriteLine("Ingrese día:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año:");
            año = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.WriteLine("Corresponde al primer trimestre");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No corresponde");
                Console.ReadLine();
            }
        }
    }
}
