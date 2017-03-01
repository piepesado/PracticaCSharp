using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class DiezElementos
    {
        private int[] vectorDiez;

        public void IngresoValores()
        {
            vectorDiez = new int[10];
            Console.WriteLine("Ingrese 10 valores, se calculará si está ordenado de menor a mayor.");
            for (int f=0; f <10; f++)
            {
                Console.WriteLine("Ingrese valor:");
                vectorDiez[f] = int.Parse(Console.ReadLine());
            }
        }
        //COPIADO DE TUTORIALES YA, NO ENTIENDO ESTE MÉTODO DE ORDENAMIENTO DE VECTOR
        public void OrdenElementos()
        {
            int orden = 1;
            for (int i=0; i <9; i++)
            {
                if (vectorDiez[i +1] < vectorDiez[i])
                {
                    orden = 0;
                }
            }
            if (orden == 1)
            {
                Console.WriteLine("Está ordenado de menor a mayor.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No está ordenado de menor a mayor.");
                Console.ReadKey();
            }
        }
        public static void Main(String[] args)
        {
            DiezElementos diezEle = new DiezElementos();
            diezEle.IngresoValores();
            diezEle.OrdenElementos();
        }
    }
}
