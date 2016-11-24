using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Métodos
{
    class TablaMultiplicar
    {
        public void CargarValor()
        {
            int valor;

            do
            {
                Console.WriteLine("Ingrese valor para que se imprima su tabla de multiplicar:");
                Console.WriteLine("-1 para Salir");
                valor = int.Parse(Console.ReadLine());
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }
        public void Calcular (int i)
        {
            for (int f = i; f<= i * 10; f = f+ i)
            {
                Console.WriteLine(f + "-");
            }
            Console.WriteLine();
        }
        static void Main(String[] args)
        {
            TablaMultiplicar multi = new TablaMultiplicar();
            multi.CargarValor();            
        }
    }
}
