using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class PesoPiezas
    {
        public static void Main(String[] args)
        {
            int peso, sumaPiezas1, sumaPiezas2, sumaPiezas3, sumaTotal; //sumaTotal no se usa nunca..
            sumaPiezas1 = 0;
            sumaPiezas2 = 0;
            sumaPiezas3 = 0;

            do
            {
                Console.WriteLine("Ingrese peso de la pieza:");
                Console.WriteLine("Salir con 0.");
                peso = int.Parse(Console.ReadLine());
                if (peso >= 10.2)
                {
                    sumaPiezas1++;
                }
                else
                {
                    if (peso >= 9.8 && peso <= 10.2)
                    {
                        sumaPiezas2++;
                    }
                    else
                    {
                        if (peso < 9.8)
                        {
                            sumaPiezas3++;
                        }
                    }
                }
            } while (peso != 0);
            sumaTotal = sumaPiezas1 + sumaPiezas2 + sumaPiezas3;
            Console.WriteLine("Se ingresaron " + sumaPiezas1 + " piezas de peso superior a 10.2kgs.");
            Console.WriteLine("Se ingresaron " + sumaPiezas2 + " piezas de 9.8 a 10.2kgs.");
            Console.WriteLine("Se ingresaron " + sumaPiezas3 + " piezas de peso menor a 9.8.");
            Console.ReadLine();
        }
    }
}
