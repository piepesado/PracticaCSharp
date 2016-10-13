using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IngresaRectangulo
    {
        double ancho;
        double largo;

        public void IngresarDatos()
        {
            Console.WriteLine("--Calcula el area de un rectangulo--");
            Console.WriteLine("Ingresar ancho del rectangulo: ");
            ancho = (double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingresar largo del rectangulo: ");
            largo = (double.Parse(Console.ReadLine()));          
        }

        public double ObternerArea()
        {
            return ancho * largo;
        }

        public void MostrarArea()
        {
            //Console.WriteLine("El ancho ingresado es: " + ancho);
            //Console.WriteLine("El largo ingresado es: " + largo);
            Console.WriteLine("El area del rectangulo es " + ObternerArea());
        }
    }

    class EjecutarRectangulo
    {
        static void Main(String[] args)
        {
            IngresaRectangulo r = new IngresaRectangulo();
            r.IngresarDatos();
            r.MostrarArea();
            Console.ReadLine();
        }
    }
}
