using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class CuentasBancarias
    {
        public static void Main(String[] args)
        {
            int numCuenta;
            float saldo, totalSaldo;
            saldo = 0;
            totalSaldo = 0;

            Console.WriteLine("Ingrse número de cuenta y su saldo. Para salir ingrese valor negativo en número de cuenta.");

            do
            {
                Console.WriteLine("Ingrese número de cuenta:");
                numCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese saldo de cuenta:");
                saldo = float.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    Console.WriteLine("La cuenta número " + numCuenta + " tiene estado Acreedora");
                    //Console.ReadKey();
                    totalSaldo = totalSaldo + saldo;
                }
                else
                {
                    if (saldo < 0)
                    {
                        Console.WriteLine("La cuenta número " + numCuenta + " tiene estado Deudora");
                        //Console.ReadKey();
                    }
                    else
                    {
                        if (saldo == 0)
                        {
                            Console.WriteLine("La cuenta número " + numCuenta + " tiene estado Nula");
                            //Console.ReadKey();
                        }
                    }
                }
            } while (numCuenta < 0);
            Console.WriteLine("La suma total de las cuentas acreedoras es de :$" + totalSaldo);
            Console.ReadKey();
        }
    }
}
