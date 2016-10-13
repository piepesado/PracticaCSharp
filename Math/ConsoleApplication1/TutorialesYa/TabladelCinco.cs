using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class TabladelCinco
    {
        public static void Main (String[] args)
        {
            int x;

            for (x = 5; x <= 50; x = x + 5)
            {
                Console.WriteLine(x);                
            }
            Console.ReadKey();
        }
    }
}
