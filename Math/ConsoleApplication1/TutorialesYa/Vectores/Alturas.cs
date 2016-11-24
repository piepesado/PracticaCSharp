using System;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class Alturas
    {
        private float[] alturas;
        private float promedio;             

        public void CargarAlturas()
        {
            alturas = new float[5];

            for (int f= 0; f < 5; f++)
            {
                Console.WriteLine("Ingrese la altura de la persona:");
                alturas[f] = float.Parse(Console.ReadLine());               
            }
        }

        public void CalcularPromedio()
        {
            float suma;
            suma = 0;

            for (int f=0; f < 5; f++)
            {
                suma = suma + alturas[f];               
            }
            promedio = suma / 5;
            Console.WriteLine("El promedio de las alturas ingresadas es de: " + promedio);
        }

        public void MayorMenor()
        {
            int mayor, menor;
            mayor = 0;
            menor = 0;

            for (int f = 0; f < promedio; f++)
            {
                if (alturas[f] > promedio)
                {
                    mayor++;
                }
                else
                {
                    if(alturas[f] < promedio)
                    {
                        menor++;
                    }                
                }
            }
            Console.WriteLine("Se ingresaron " + mayor + " alturas mayores al promedio.");
            Console.WriteLine("Se ingresaron " + menor + " alturas menores al promedio.");
            Console.ReadKey();
        }

        static void Main(String[] args)
        {
            Alturas alt = new Alturas();
            alt.CargarAlturas();
            alt.CalcularPromedio();
            alt.MayorMenor();
        }
    }
}
