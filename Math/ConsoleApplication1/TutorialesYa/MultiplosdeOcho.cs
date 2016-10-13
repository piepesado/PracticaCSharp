using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class MultiplosdeOcho
    {
        public static void Main (String[] args)
        {            
            int num = 0;            

            while (num <= 500)
            {
                num = num + 8;
                Console.WriteLine(num);     //muestra hasta 504           
            }            
            Console.ReadKey();
        }
    }
}
