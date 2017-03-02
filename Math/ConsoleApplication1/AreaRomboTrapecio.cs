using System;

namespace ConsoleApplication1
{
    class AreaRomboTrapecio
    {
        //variables rombo
        double diagonalMenor;
        double diagonalMayor;
        //variables trapecio
        double baseMenor;
        double baseMayor;
        double altura;

        //condicional para seleccionar rombo o trapecio
        public static void IngresarDatos()
        {
            Console.WriteLine("--Ingrese figura para calcular area");
            Console.WriteLine("'Rombo' / 'Trapecio'");
            String figura = Console.ReadLine();

            switch (figura)
            {
                case "Rombo":
                    {
                        //Los metodos no pueden estar escritos dentro del case
                        AreaRombo();
                        break;
                    }
                case "Trapecio":
                    {
                        AreaTrapecio();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Figura ingresada no es correcta");
                        break;
                    }
            }
        }

        public double AreaRombo()
        {
            Console.WriteLine("Ingrese diagonal menor del rombo:");
            diagonalMenor = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese diagonal mayor del rombo");
            diagonalMayor = (double.Parse(Console.ReadLine()));

            return (diagonalMenor * diagonalMayor) / 2;
        }

        public double AreaTrapecio()
        {
            Console.WriteLine("Ingrese base menor del trapecio:");
            baseMenor = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese base mayor del trapecio:");
            baseMayor = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese altura del trapecio:");
            altura = (double.Parse(Console.ReadLine()));

            return (((baseMenor + baseMayor) / 2) * altura);
        }

        public static void MostrarResultado(string figura)
        {
            if (figura == "Rombo")
            {
                Console.WriteLine("El area del rombo es: " + AreaRombo());
            }

            if (figura == "Trapecio")
            {
                Console.WriteLine("El area del trapecio es: " + AreaTrapecio());
            }
        }        


        public static void Main(String figura)
        {
            AreaRomboTrapecio Art = new AreaRomboTrapecio();
            Art.IngresarDatos();
            Art.MostrarResultado(figura);
            Console.ReadLine();
        }
    }
}