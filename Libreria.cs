using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    public class Libreria
    {
        private string nombre;
        private string direccion;
        private List<Articulo> articulos;
        private List<Venta> ventas;

        public Libreria()
        {
        }

        public bool VenderArticulo(Articulo articulo, Persona persona)
        {
            return false;
        }

        public Articulo ObtenerArticulo(int posicion)
        {
            return null;
        }

        public void AgregarArticulo(Articulo articulo)
        {

        }

        public int ObtenerCantidadDeVentas()
        {
            return 0;
        }

        public int ObtenerMontoDeVentas()
        {
            return 0;
        }

        public string ObtenerDescripcion()
        {
            return "";
        }
    }
}
