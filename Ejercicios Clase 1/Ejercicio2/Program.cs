using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngresado;
            double numeroCuadrado;
            double numeroCubo;

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();

            while(int.TryParse(numeroIngresado, out numero) != true || numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroIngresado = Console.ReadLine();
            }
            numeroCuadrado = Math.Pow(numero,2);
            numeroCubo = Math.Pow(numero, 3);
            Console.WriteLine("El numero era: {0}, su cuadrado es {1} y su cubo es {2}",numero,numeroCuadrado,numeroCubo);
        }
    }
}
