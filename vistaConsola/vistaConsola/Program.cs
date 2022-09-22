using System;

namespace vistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string edadIngresada;
            int edad;
            bool conversionExitosaInt;
            bool conversionExitosaFloat;
            //a la declaracion de los float hay que ponerle
            //la "f" al final
            float numeroDecimal = 10.5f;
            string precioIngresado;
            float precio; 


            nombre = Console.ReadLine();
            edadIngresada = Console.ReadLine();
            conversionExitosaInt = int.TryParse(edadIngresada, out edad);
            precioIngresado = Console.ReadLine();
            conversionExitosaFloat = float.TryParse(precioIngresado, out precio);
            
            Console.WriteLine(nombre);
            Console.WriteLine("Su edad es " + edad);
            Console.WriteLine("Se pudo convertir? : " + conversionExitosaInt);
            
            //otra forma de escribir en consola, el enviroment.NewLine sirve para poner un salto de linea en cualquier sistema operativo
            Console.WriteLine("su edad es {0} y su nombre es {1}. {2}Querido {1} tiene {0} años y su precio es {3}",edad,nombre,Environment.NewLine, precio);
            

            //ARRAYS
            string [] nombres = new string[2];
            nombres[0] = "German";
            nombres[1] = "Gabriel";
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);  
            }

            string[] paises = { "Arg", "Brazil", "Peru" };

            foreach(string pais in paises)
            {
                Console.WriteLine(pais);   
            }
        }
    }
}
