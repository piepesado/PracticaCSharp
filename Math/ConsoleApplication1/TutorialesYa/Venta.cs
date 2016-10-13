using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Venta
    {
        public static void Main(String[] args)
        {
            decimal precio;
            int cantidad;
            decimal total;            

            Console.WriteLine("Ingrese el precio del articulo:");
            precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad: ");
            cantidad = Convert.ToInt16(Console.ReadLine());
            total = Convert.ToInt16(precio * cantidad);
            Console.WriteLine("El total a abonar es: " + total); //cuando el precio es float, o sea con decimales en el total no aparece el punto
            Console.ReadLine();
        }
    }
}
