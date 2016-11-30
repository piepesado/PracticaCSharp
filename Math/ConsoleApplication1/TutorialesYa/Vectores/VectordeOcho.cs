using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class VectordeOcho
    {
        private int[] ochoValores;
       
        public void CargaValores()
        {
            ochoValores = new int[8];
            Console.WriteLine("Ingrese 8 valores:");
            for (int i = 0; i <8; i++)
            {
                Console.WriteLine("Digite valor:");
                ochoValores[i] = int.Parse(Console.ReadLine());
            }
        }

        public void AcumularElementos()
        {
            int suma = 0;
            for (int i = 0; i < 8; i++)
            {
                suma = suma + ochoValores[i];
            }
            Console.WriteLine("La suma de los valores ingresados es: " + suma);
        }

        public void ValorMayores36()
        {
            int suma = 0;
            for (int i = 0; i < 8; i++)
            {
                if (ochoValores[i] > 36)
                {
                    suma = suma + ochoValores[i];
                }
            }
            Console.WriteLine("La suma de los los valores ingresados mayores a 36 es: " + suma);            
        }

        public void CantidadMayore50()
        {
            int cantidad = 0;
            for (int i = 0; i < 8; i++)
            {
                if (ochoValores[i] > 50)
                {
                    cantidad++;
                }
            }
            Console.WriteLine("Se ingresaron " + cantidad + " valores mayores a 50.");
            Console.ReadKey();
        }

        public static void Main(String[] args)
        {
            VectordeOcho vector8 = new VectordeOcho();
            vector8.CargaValores();
            vector8.AcumularElementos();
            vector8.ValorMayores36();
            vector8.CantidadMayore50();
        }
    }
}
