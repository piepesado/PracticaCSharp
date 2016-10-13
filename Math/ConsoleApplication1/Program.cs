using System;

namespace BasicProgrammingConsole
{
    class Math
    {
        public static void Main(String[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Suma dos números");
            Console.WriteLine("Ingrese el primer número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de los dos números es: " + (numero1 + numero2));
            Console.ReadLine();
        }

    }
}
