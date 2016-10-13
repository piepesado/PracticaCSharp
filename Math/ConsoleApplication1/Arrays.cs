using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Arrays
    {
        static void Main(String[] args)
        {
            string[] oGuitars = new string[3];

            oGuitars[0] = "Squire Bullet Strat";
            oGuitars[1] = "Epiphone SG G400";
            oGuitars[2] = "PRS Torero";
            

            for (int i = 0; i < oGuitars.Length; i++)
            {
                Console.WriteLine("The guitar number " + i + " is the " + oGuitars[i]);
                Console.ReadLine();
            }
            //foreach (string s in oGuitars)
            //Console.WriteLine(s);
            //Console.ReadLine();
        }
    }
}
