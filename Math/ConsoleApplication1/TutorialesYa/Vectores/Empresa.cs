using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorialesYa.Vectores
{
    class Empresa
    {
        private float[] sueldosMañana;
        private float[] sueldosTarde;

        public void CargaSueldos()
        {
            sueldosMañana = new float[4];
            sueldosTarde = new float[4];
            Console.WriteLine("Ingrese el sueldo del empelado turno mañana:");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese Sueldo:");
                sueldosMañana[f] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el sueldo del empleado turno noche:");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese Sueldo:");
                sueldosTarde[f] = float.Parse(Console.ReadLine());
            }
        }
        public void ImprimeGastos()
        {
            float man = 0;
            float tar = 0;
            for (int f = 0; f < 4; f++)
            {
                man = man + sueldosMañana[f];
                tar = tar + sueldosTarde[f];
            }
            Console.WriteLine("Los gastos para el turno de la mañana son de " + man + " pesos.");
            Console.WriteLine("Los gastos para el turno de la tarde son de " + tar + " pesos");
            Console.ReadKey();
        }
        static void Main (String[] args)
        {
            Empresa emp = new Vectores.Empresa();
            emp.CargaSueldos();
            emp.ImprimeGastos();
        }
    }
}
