using System;

namespace ConsoleApplication1.TutorialesYa
{
    class PerfilesHierro
    {
        public static void Main(String[] args)
        {
            int piezas;
            int piezasAptas = 0;
            float longitud;
            int x = 1;

            Console.WriteLine("Piezas para procesar:");
            piezas = int.Parse(Console.ReadLine());

            while (x <= piezas)
            {
                Console.WriteLine("Ingrese la medida del perfil de hierro:");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    piezasAptas = piezasAptas + 1;
                }
                x = x + 1;
            }            
            Console.WriteLine("Existen " + piezasAptas + " piezas validas en el lote.");//no me suma la cantidad de piezas aptas
            Console.ReadKey();
        }
    }
}
