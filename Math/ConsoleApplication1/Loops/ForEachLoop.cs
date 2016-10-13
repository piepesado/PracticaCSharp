using System;
using System.Collections;
//using System.Collections;

namespace ConsoleApplication1.Loops
{
    class ForEachLoop
    {
        static void Main(String[] args)
        {        
            ArrayList oGatos = new ArrayList();
            oGatos.Add("Kemet");
            oGatos.Add("Gato Vaca");
            oGatos.Add("Compota");

            foreach(string name in oGatos)

            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}

