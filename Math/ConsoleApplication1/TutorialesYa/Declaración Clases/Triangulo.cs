using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class Triangulo
    {
        private int lado1, lado2, lado3;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el Lado 1 del triangulo:");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Lado 2 del triangulo:");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Lado 3 del triangulo:");
            lado3 = int.Parse(Console.ReadLine());
        }

        public void LadoMayor()
        {
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine("El lado 1 es el mayor. Su valor es: " + lado1);
            }
            else
            {
                if (lado2 > lado3)
                {
                    Console.WriteLine("El lado 2 es el mayor. Su valor es: " +lado2);
                }
                else
                {
                    Console.WriteLine("El lado 3 es el mayor. Su valor es " +lado3);
                }
            }
        }

        public void Equilatero()
        {
            if (lado1 == lado2 && lado3 == lado2)
            {
                Console.WriteLine("El traingulo es equilatero.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El triangulo no es equilatero.");
                Console.ReadKey();
            }
        }

        static void Main (String[] args)
        {
            Triangulo tri = new Triangulo();
            tri.Inicializar();
            tri.LadoMayor();
            tri.Equilatero();
            Console.ReadKey();
        }        
    }
}
