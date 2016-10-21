using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class TiposTriangulos
    {
        public static void Main(String[] args)
        {
            int n, x;
            int baseT, lado1T, lado2T, equilatero, isoceles, escaleno;
            equilatero = 0;
            isoceles = 0;
            escaleno = 0;

            Console.WriteLine("Ingrese cuantos triangulos ingresará:");
            n = int.Parse(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                Console.WriteLine("Ingrese base del triangulo:");
                baseT = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese lado 1 del triangulo:");
                lado1T = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese lado 2 del triangulo:");
                lado2T = int.Parse(Console.ReadLine());

                if (baseT == lado1T && baseT == lado2T)
                {
                    Console.WriteLine("Es un triangulo equilatero");
                    equilatero++;
                }
                else
                {
                    if (baseT == lado1T || baseT == lado2T || lado1T == lado2T)
                    {
                        Console.WriteLine("Es un triangulo isoceles");
                        isoceles++;
                    }
                    else
                    {
                        Console.WriteLine("El triangulo es un escaleno");
                        escaleno++;
                    }
                }               
            }

            Console.WriteLine("Se ingresaron " + equilatero + " triangulos equilateros.");
            Console.WriteLine("Se ingresaron " + isoceles + " triangulos isoceles.");
            Console.WriteLine("Se ingresaron " + escaleno + " triangulos escaleno.");
                
            if (equilatero < isoceles && equilatero < escaleno)
            {
                Console.WriteLine("El triangulo equilatero es el que se ingresó menor cantidad");
            }
            else
            {
                if (isoceles < escaleno)
                {
                    Console.WriteLine("El triangulo isoceles es el que se ingresó menor cantidad");
                }
                else
                {
                    Console.WriteLine("El triangulo escaleno es el que se ingresó menor cantidad");
                }
            }
            Console.ReadKey();
        }
    }
}
