using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class Empleados
    {
        string nombre;
        decimal sueldo;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo:");
            sueldo = decimal.Parse(Console.ReadLine());

        }
        public void Imprimir()
        {
            Console.WriteLine("Se ingresó el empleado " + nombre + " con un sueldo de $" + sueldo);            
        }
        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe abonar impuestos.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El empleado está exento de impuestos.");
                Console.ReadKey();
            }
        }
        static void Main(String[] args)
        {
            Empleados emp1 = new Empleados();
            emp1.Inicializar();
            emp1.Imprimir();
            emp1.PagaImpuestos();
        }
    }
}
