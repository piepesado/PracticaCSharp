using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MethodsPractice
    {
        static void Main(String[] args) { }
        
            public static int AddNumbers(int number1 = 19, int number2 = 10)
            {
            int result = (number1 + number2);
            Console.WriteLine(result);
            return result;
            }
    }
}
