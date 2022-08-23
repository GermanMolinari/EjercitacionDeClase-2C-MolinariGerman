using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int contadorDeDivisores = 0;
            int contadorDePrimos = 0;
            int numero;

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();

            while(int.TryParse(numeroIngresado, out numero) != true)
            {
                Console.WriteLine("Error, reingrese el numero o escriba 'salir' ");
                numeroIngresado = Console.ReadLine();
                if(numeroIngresado == "salir")
                {
                    break;
                }
            }
            if(numero < 0)
            {
                numero = numero * -1;
            }
            //falta otro for para intentar una userte de algoritmo de burbujeo.. funcionará??? kien sabe
        
                for(int i = 1; i <= numero; i++)
                {
                    if(numero % i == 0)
                    {
                        contadorDeDivisores++;
                    }
                }
                if(contadorDeDivisores == 2)
                {
                    contadorDePrimos++;
                }
            Console.WriteLine("los primos desde " + numero + "al 0 son " + contadorDePrimos);
        }   
    }
}
