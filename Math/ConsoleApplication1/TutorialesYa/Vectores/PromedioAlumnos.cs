using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class PromedioAlumnos
    {
        private int[] cursoA;
        private int[] cursoB;
        
        public void IngresarNotas()
        {
            cursoA = new int[5];
            cursoB = new int[5];
            Console.WriteLine("Notas grupo A:");
            for (int f=0; f <5; f++)
            {
                Console.WriteLine("Ingrese nota A:");
                cursoA[f] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Notas grupo B:");
            for (int z=0; z <5; z++)
            {
                Console.WriteLine("Ingrese nota B:");
                cursoB[z] = int.Parse(Console.ReadLine());
            }
        }
        public void MayorPromedio()
        {
            int suma1 = 0;
            int suma2 = 0;
            int promedio1, promedio2;
            for (int i=0; i <5; i++)
            {
                suma1 = suma1 + cursoA[i];
                suma2 = suma2 + cursoB[i];
            }
            promedio1 = suma1 / 5;
            promedio2 = suma2 / 5;
            if (promedio1 > promedio2)
            {
                Console.WriteLine("Grupo A obtuvo mayor promedio.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Grupo B obtuvo mayor promedio.");
                Console.ReadKey();
            }
        }
        public static void Main(String[] args)
        {
            PromedioAlumnos proAlu = new PromedioAlumnos();
            proAlu.IngresarNotas();
            proAlu.MayorPromedio(); 
        }
    }
}
