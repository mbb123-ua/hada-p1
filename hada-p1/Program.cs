using System;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unidad;
            double cantidad;
            double resultado;
            string continuar;

            do
            {
                Console.WriteLine("Introduce la unidad de origen (segundos/minutos):");
                unidad = Console.ReadLine().ToLower();

                Console.WriteLine("Introduce la cantidad:");
                cantidad = double.Parse(Console.ReadLine());

                if (unidad == "segundos")
                {
                    resultado = HadaP1.Seconds2Minutes(cantidad);
                    Console.WriteLine(cantidad + " segundos son " + resultado + " minutos");
                }
                else if (unidad == "minutos")
                {
                    resultado = HadaP1.Minutes2Seconds(cantidad);
                    Console.WriteLine(cantidad + " minutos son " + resultado + " segundos");
                }
                else
                {
                    Console.WriteLine("Unidad no válida");
                }

                Console.WriteLine("¿Quieres realizar otra conversión? (s/n)");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            Console.WriteLine("Programa finalizado");
        }
    }
}