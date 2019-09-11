using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_Núm._7
{
    //Alberto Galdámez 11/09/2019
    class Ejercicio1
    {
        static int[] edades;
        static void Main(string[] args)
        {
            int contadorMenores = 0;
            int contadorMayores = 0;

            //Proceso
            Console.WriteLine("----Ingreso de edades----");
            Console.Write("Escriba el numero de personas que le asignará edades: ");
            int numeroPersonas = Convert.ToInt32(Console.ReadLine());
            edades = new int[numeroPersonas];
            for (int inicio = 1; inicio <= numeroPersonas; inicio++)
            {
                Console.Clear();
                Console.WriteLine("Escriba la edad de la Persona Núm.{0}", inicio);
                Console.Write("Edad: ");
                edades[inicio - 1] = Convert.ToInt32(Console.ReadLine());
                if (edades[inicio - 1] <= 17)
                {
                    contadorMenores = contadorMenores + 1;
                    
                }
                else
                {

                    if (edades[inicio - 1] >= 18)
                    {
                        contadorMayores = contadorMayores + 1;
                        
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nCantidad de Menores de edad: {0}", contadorMenores);
            Console.WriteLine("Cantida de Mayores de edad: {0}", contadorMayores);
            Console.ReadKey();
        }
    }
}
