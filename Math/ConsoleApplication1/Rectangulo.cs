using System;

namespace ConsoleApplication1
{
    class Rectangulo
    {
        double ancho;
        double largo;
        
        public void AceptarDetalles()
        {
            ancho = 13.4;
            largo = 7.6;
        }

        public double ObtenerArea()
        {
            return ancho * largo;
        }

        public void MostrarArea()
        {
            Console.WriteLine("El ancho es: " + ancho);
            Console.WriteLine("El largo es: " + largo);
            Console.WriteLine("El area del rectangulo es: " + ObtenerArea());
        }
    }

    class EjecutarRectangulo
    {
        static void Main(String[] args)
        {
            Rectangulo r = new Rectangulo();
            r.AceptarDetalles();            
            r.MostrarArea();
            Console.ReadLine();
        }
    }
}
