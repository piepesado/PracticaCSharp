using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SwitchStatement
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Cual es el gato peor comportado? (Gato Vaca/Kemet/Potito)");
            String gato = Console.ReadLine();

            switch (gato)
            {
                case "Kemet":
                case "Gato Vaca":
                    Console.WriteLine("Incorrecto! son gatos bastante bien comportados..");
                    Console.ReadLine();
                    break;
                case "Potito":
                    Console.WriteLine("Correcto! El gato compota es el gato peor comportado.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("No se entiende lo que escribistes");
                    break;                    
            }            
        }
    }
}
