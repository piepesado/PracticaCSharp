using System;


namespace ConsoleApplication1.TutorialesYa.Declaración_Clases
{
    class Persona
    {
        private string nombre;
        private int edad;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona:");
            edad = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.WriteLine("El nombre de la persona es " + nombre + " y su edad es de " + edad + " años.");
        }

        public void EsMayor()
        {
            if (edad >= 18)
            {
                Console.WriteLine("La perona ingresada es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona ingresada es menor de edad.");
            }
            Console.ReadKey();
        }

        static void Main(String[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayor();
        }
     }    
}
