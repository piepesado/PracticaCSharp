using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SwitchGuitars
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Select the japan made guitar.");
            Console.WriteLine("Gibson, Squier or Ibanez");
            String guitar = Console.ReadLine();

            switch (guitar)
            {
                case "Gibson":
                case "Squier":
                    Console.WriteLine("This are not japanese made guitars!");
                    Console.ReadLine();
                    break;
                case "Ibanez":
                    Console.WriteLine("Correct!! Ibanez produces guitars on the land of the rising sun!");
                    break;
                default:
                    Console.WriteLine("Brand not recognized.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
