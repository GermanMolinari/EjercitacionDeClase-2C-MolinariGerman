using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsesionaria
{
    public class Gerente
    {
        string nombre;
        int antiguedad;
        int edad;
        float ganancia;

        public Gerente(string nombre, int antiguedad, int edad, float ganancia)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.edad = edad;
            this.ganancia = ganancia;

        }
    }

}
