using System;

namespace ConsoleApplication1.TutorialesYa
{
    class MayorNumero
    {
        public static void Main(String[] args)
        {
            int num1, num2;

            Console.WriteLine("Ingrese numero 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero 2:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero 1 es mayor que el numero 2");
                Console.ReadLine();
            }else
            {
                Console.WriteLine("El numero 2 es mayor que el numero 1");
                Console.ReadLine();
            }
        }
    }
}
