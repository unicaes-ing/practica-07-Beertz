using System;


namespace Práctica_Núm._7.Ejercicios
{
    //Alberto Galdámez
    class Ejercicio2
    {
        static decimal[] numeros;

        static void Main(string[] args)
        {
            int pares = 0;
            int impares = 0;
            Console.WriteLine("[Contador De Numeros Pares & Impares]");
            Console.Write("Escriba la cantidad de numeros a Digitar: ");
            int llevaCuenta = Convert.ToInt32(Console.ReadLine());
            numeros = new decimal[llevaCuenta];
            for (int inicio = 1; inicio <= llevaCuenta; inicio++)
            {
                Console.Clear();
                Console.WriteLine("Escriba el Numero Núm.{0} de los parametros establecidos", inicio);
                Console.Write("Numero: ");
                numeros[inicio - 1] = Convert.ToDecimal(Console.ReadLine());
                if (numeros[inicio - 1] % 2 == 0)
                {

                    pares = pares + 1;
                }
                else
                {
                    if (numeros[inicio - 1] % 2 >= 1)
                    {
                        impares = impares + 1;
                    }

                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cantidad de Numeros Pares = {0}", pares);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cantidad de Numeros Impares = {0}", impares);
            Console.ReadKey();
        }
    }
}
