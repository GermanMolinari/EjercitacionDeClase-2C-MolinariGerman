using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngresado;
            int min = 0;
            int max = 0;
            int acum = 0;
            bool parseoExitoso;
            float promedio;
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero #{0}: ",i+1);
                numeroIngresado = Console.ReadLine();
                parseoExitoso = int.TryParse(numeroIngresado, out numero);

                if ((i == 0 && parseoExitoso) || (parseoExitoso && numero > max))
                {
                    max = numero;
                }
                if((i == 0 && parseoExitoso) || (parseoExitoso && numero < min))
                {
                    min = numero;
                }
                acum += numero;
            }
            promedio = acum / 5;
            Console.WriteLine("Max: {0}, Min: {1}, Promedio {2}", max,min,promedio);
        }
    }
}
