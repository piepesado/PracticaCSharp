using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class Puntajes
    {
        private float[] puntajes;
        private float promedio;

        public void IngresarDatos()
        {
            puntajes = new float[8];
            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine("Ingrese el puntaje:");
                puntajes[x] = float.Parse(Console.ReadLine());
            }
        }
        public void CalcularPromedio()
        {
            float suma = 0;
            for (int x = 0; x < 8; x++)
            {
                suma = suma + puntajes[x];
            }
            promedio = suma / 8;
            Console.WriteLine("El promedio de los puntajes ingresados es de " + promedio);
        }
        public void MayorMenor()
        {
            int mayor = 0;
            int menor = 0;
            for (int x = 0; x < 8; x++)
            {
                if(puntajes[x] < promedio)
                {
                    menor++;
                }
                else
                {
                    if(puntajes[x] > promedio)
                    {
                        mayor++;
                    }
                }
            }
            Console.WriteLine("Se ingresaron " + menor + " puntajes menores al promedio.");
            Console.WriteLine("Se ingresaron " + mayor + " puntajes mayores al promedio.");
            Console.ReadKey();
        }
        static void Main (String[] args)
        {
            Puntajes pun = new Vectores.Puntajes();
            pun.IngresarDatos();
            pun.CalcularPromedio();
            pun.MayorMenor();
        }
    }
}
