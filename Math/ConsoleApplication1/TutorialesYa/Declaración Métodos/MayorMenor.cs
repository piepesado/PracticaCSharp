using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Métodos
{
    class MayorMenor
    {
        public void CargarValores()
        {
            Console.WriteLine("Ingresar valor 1:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar valor2:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar valor 3:");
            int valor3 = int.Parse(Console.ReadLine());

            int mayor, menor;
            mayor = CalcularMayor(valor1, valor2, valor3);
            menor = CalcularMenor(valor1, valor2, valor3);
            Console.WriteLine("El valor mayor de los tres ingresado es: " + mayor);
            Console.WriteLine("El valor menor de los tres ingresados es: " + menor);
            
        }
        public int CalcularMayor (int v1, int v2, int v3){

            int m;
            if (v1 > v2 && v1 > v3)
            {
                m = v1;
            }
                else
            {
                if (v2 > v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        public int CalcularMenor (int v1, int v2, int v3)
        {
            int m;
            if (v1 < v3 && v1 < v2)
            {
                m = v1;
            }
            else
            {
                if (v2 < v1 && v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    if (v3 < v1 && v3 < v2)
                    {
                        m = v3;
                    }
                }
            }
            return m;
        }

        static void Main (String[] args)
        {
            MayorMenor mm = new MayorMenor();
            mm.CargarValores();
            Console.ReadKey();
        }
    }
}
