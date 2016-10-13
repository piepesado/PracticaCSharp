using System;

namespace ConsoleApplication1
{
    class AreaCirculo
    {
        static double pi = 3.1416;
        double radio;
        

        public void IngresarRadio()
        {
            Console.WriteLine("--CALCULA AREA DE CIRCULO--");
            Console.WriteLine("Ingresa radio del circulo:");
            radio = (double.Parse(Console.ReadLine()));
        }

        public double ObtenerArea()
        {
            return radio * radio * pi;
        }

        public void MostrarArea()
        {
            Console.WriteLine("El area del traingulo es: " + ObtenerArea());
        }
                
            static void Main(String[] args)
            {
                AreaCirculo c = new AreaCirculo();
                c.IngresarRadio();
                c.MostrarArea();
                Console.ReadLine();
            }    
    }
}
