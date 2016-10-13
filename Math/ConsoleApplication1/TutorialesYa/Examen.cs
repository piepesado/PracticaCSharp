using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa
{
    class Examen
    {
        public static void Main(String[] args)
        {
            int cantidadPreguntas, respuestasCorrectas, porcentaje;

            Console.WriteLine("Ingrese la cantidad de preguntas formuladas");
            cantidadPreguntas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de preguntas respondidas correctamente:");
            respuestasCorrectas = int.Parse(Console.ReadLine());

            porcentaje = ((respuestasCorrectas * 100) / cantidadPreguntas);

            if (porcentaje >= 90)
            {
                Console.WriteLine("Nivel máximo");
                Console.ReadLine();
            }
            else
            {
                if (porcentaje >= 70 && porcentaje < 90)
                {
                    Console.WriteLine("Nivel medio");
                    Console.ReadLine();
                }
                else
                {
                    if (porcentaje >= 50 && porcentaje < 70)
                    {
                        Console.WriteLine("Nivel regular");
                        Console.ReadLine();
                    }
                    else
                    {
                        if (porcentaje < 50)
                        {
                            Console.WriteLine("Nivel malo");
                            Console.ReadLine();
                        }
                    }
                }
            }     
           
        }
    }
}
