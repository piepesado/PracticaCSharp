using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class PruebaVector2
    {
        private int [] montos;

        public void Cargar()
        {
            montos = new int[4];

            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("Ingrese monto:");
                montos[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine(montos[f]);
                Console.ReadKey();
            }
        }
        static void Main (String[] args)
        {
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.Imprimir();
        }
    }
}
