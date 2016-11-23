using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class Cuadrado
    {
        private int lado;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado:");
            lado = int.Parse(Console.ReadLine());
        }

        public void ImprimePerímetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
        }

        public void ImprimeArea()
        {
            int area;
            area = lado * lado;
            Console.WriteLine("El área del cuadrado es: " + area);
        }

        static void Main(String[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Inicializar();
            cuadrado1.ImprimePerímetro();
            cuadrado1.ImprimeArea();
            Console.ReadKey();

        }
    }
}
