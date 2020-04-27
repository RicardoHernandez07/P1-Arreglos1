using System;

namespace P1_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
            "agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            Console.WriteLine("Introdusca el numero del mes que desea saber");
            int NMes = 0;
            bool entero = Int32.TryParse(Console.ReadLine(), out NMes);


            if (entero || NMes < 1 || NMes > 13)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(meses[i]);
                }
            }
            else
            {
                Console.WriteLine("Seleccionaste el mes de .- ");
            }
        }
    }
}
