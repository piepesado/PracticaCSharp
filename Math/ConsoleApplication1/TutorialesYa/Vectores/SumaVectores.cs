using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class SumaVectores
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vecSuma;

        public void CargaVectores()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            Console.WriteLine("Carga de 2 grupos de 4 números cada uno.");
           
            for ( int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese un valor 1er vector:");
                vector1[i] = int.Parse(Console.ReadLine());
            }            
            for ( int f = 0; f < 4; f++)
            {
                Console.WriteLine("Ingrese un valor 2do vector:");
                vector2[f] = int.Parse(Console.ReadLine());
            }
        }
        public void Suma()
        {
            vecSuma = new int[4];
            for ( int x = 0; x < 4; x++)
            {
                vecSuma[x] = vector1[x] + vector2[x];
            }
            Console.WriteLine("El resultado de la suma de los dos vectores es:");
            for (int z=0; z < 4; z++)
            {
                Console.WriteLine(vecSuma[z]);                
            }
            Console.ReadKey();
        }
        public static void Main(String[] args)
        {
            SumaVectores sumVec = new SumaVectores();
            sumVec.CargaVectores();
            sumVec.Suma();
        }
    }
}
