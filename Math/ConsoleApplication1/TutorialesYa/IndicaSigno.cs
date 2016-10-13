using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class IndicaSigno
    {
        public static void Main(String[] args)
        {
            int valor;

            Console.WriteLine("Ingrese un valor");
            valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("Es un valor positivo");
                Console.ReadLine();
            }
            else
            {
                if (valor == 0)
                {
                    Console.WriteLine("El valor es cero");
                    Console.ReadLine();
                }
                else
                {
                    if (valor < 0)
                    {
                        Console.WriteLine("El valor es negativo");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
