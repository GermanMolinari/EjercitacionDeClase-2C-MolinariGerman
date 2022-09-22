using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsesionaria
{
    public class Sucursal
    {
        Gerente gerente;
        int capacidad;
        List<Auto> listaAutos;
        string ubicacion;
        string telefono;

        public Sucursal(Gerente gerente, int capacidad, string ubicacion, string telefono)
        {
            this.gerente = gerente;
            this.capacidad = capacidad;
            this.telefono = telefono;
            this.ubicacion = ubicacion;
            listaAutos = new List<Auto>();
        }



        public bool AgregarAuto(Auto nuevoAuto)
        {
            if(nuevoAuto is not null && listaAutos.Count < capacidad)
            {
                listaAutos.Add(nuevoAuto);
                return true;
            }
            return false;
        }
    }
}

