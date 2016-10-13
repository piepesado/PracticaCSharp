using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SwitchBooks
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Choose the science fiction book that it is Science Fiction:");
            Console.WriteLine("Don Quijote de la Mancha / Star Wars / Unlimited Power");
            String books = Console.ReadLine();

            switch (books)
            {
                case "Don Quijote de la Mancha":
                case "Unlimited Power":
                    Console.WriteLine("Those are not science fiction books!");
                    Console.ReadLine();
                    break;
                case "Star Wars":
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
