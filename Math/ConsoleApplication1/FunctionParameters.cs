using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FunctionParameters
    {

        static void Main(string[] args)
        {
            GreetPersons(0);
            GreetPersons(25, "John", "Jane", "Tarzan");
            Console.ReadKey();
        }

        static void GreetPersons(int someUnusedParameter, params string[] names)
        {
            foreach (string name in names)
                Console.WriteLine("Hello, " + name);
        }
    }
}
