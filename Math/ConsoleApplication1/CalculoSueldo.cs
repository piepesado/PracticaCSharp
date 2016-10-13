using System;

namespace ConsoleApplication1
{
    class CalculoSueldo
    {
        public static void Main(String[] args)
        {
            float costoHora;
            float sueldo;
            int horasTrabajadas;

            Console.WriteLine("Ingrese las horas trabajadas:");
            horasTrabajadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo de la hora de trabajo:");
            costoHora = float.Parse(Console.ReadLine());
            sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("El sueldo del operario es: $" + sueldo);
            Console.ReadLine();
    }


    }
}
