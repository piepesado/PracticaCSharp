using System;
using System.Collections;

namespace ConsoleApplication1
{
    class ForEachGuitars
    {
        static void Main(String[] args)
        {
            ArrayList oGuitars = new ArrayList();
            oGuitars.Add("Blackjack");
            oGuitars.Add("SG");
            oGuitars.Add("Torero");
            oGuitars.Add("Snakebyte");

            foreach (string model in oGuitars)
            {
                Console.WriteLine(model);
                Console.ReadLine();
            }
        }        
    }
}
