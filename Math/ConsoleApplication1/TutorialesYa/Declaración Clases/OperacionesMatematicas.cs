using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class OperacionesMatematicas
    {
        int valor1, valor2;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el primer valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
        }
        public void ImprimeSuma()
        {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("Suma: " + suma);
        }
        public void ImprimeResta()
        {
            int resta;
            resta = valor1 - valor2;
            Console.WriteLine("Resta: " + resta); 
        }
        public void ImprimeProducto()
        {
            int producto;
            producto = valor1 * valor2;
            Console.WriteLine("Producto: " + producto);
        }
        public void ImprimeDivisión()
        {
            int división;
            división = valor1 / valor2;
            Console.WriteLine("División: " + división);
            Console.ReadLine();
        }
        static void Main (String[] args)
        {
            OperacionesMatematicas opMat = new OperacionesMatematicas();
            opMat.Inicializar();
            opMat.ImprimeSuma();
            opMat.ImprimeResta();
            opMat.ImprimeProducto();
            opMat.ImprimeDivisión();

        }
    }
}
