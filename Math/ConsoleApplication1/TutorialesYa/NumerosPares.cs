using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class NumerosPares
    {
        public static void Main(String[] args)
        {
            int x, n;
            x = 1;
            int valor = 0;
            int numerosPares = 0;
            int numerosImpares = 0;

            Console.WriteLine("Cuántos números ingresará?");
            n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                Console.WriteLine("Ingrese número:");
                valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    numerosPares = numerosPares + 1;
                }
                else
                {
                    numerosImpares = numerosImpares + 1;
                }
                x = x + 1;
            }
            Console.WriteLine("Se ingresaron " + numerosPares + " números pares y " + numerosImpares + " números impares.");
            Console.ReadKey();
        }
    }
}
