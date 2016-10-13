using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Triangulos
    {
        public static void Main (String[] args)
        {
            int n = 0;
            int x;
            int baseT, alturaT, superficieT, cantidad;
            cantidad = 0;

            Console.WriteLine("Ingrese cuantos pares de datos de base y altura de triangulos ingresará:");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                Console.WriteLine("Ingrese la base del triangulo:");
                baseT = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo:");
                alturaT = int.Parse(Console.ReadLine());
                superficieT = (baseT * alturaT) / 2;
                Console.WriteLine("La base del triangulo ingresado es de " + baseT + ", su altura " + alturaT + " y su superficie " + superficieT);
                if (superficieT > 12)
                {
                    cantidad = cantidad + 1;
                }
            }
            Console.WriteLine("Se ingresaron " + cantidad + " triangulos cuya superficie es mayor a 12");
            Console.ReadKey();
        }
    }
}
