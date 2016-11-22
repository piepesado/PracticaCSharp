using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class Punto
    {
        private int x, y;

        public void Carga()
        {
            Console.WriteLine("Ingrese el valor de x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y:");
            y = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se ubica en el Primer Cuadrante.");
                
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se ubica en el Segundo Cuadrante.");
                    
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se ubica en el Tercer Cuadrante.");
                        
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("El punto se ubica en el Cuarto Cuadrante.");
                        }
                        else
                        {
                            Console.WriteLine("El punto no se encuentra en ningún cuadrante.");
                        }
                    }
                }
            }
            Console.ReadKey();
         }

        // static void Main (string[) args){

        //        Punto punto1 = new Punto();
        //        punto1.
                
                                        
        //}
    }
}
