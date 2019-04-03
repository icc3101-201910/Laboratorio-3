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

        public Libreria(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            articulos = new List<Articulo>();
            ventas = new List<Venta>();
        }

        public bool VenderArticulo(Articulo articulo, Persona persona)
        {
            if (articulo.TieneStock()) {
                articulo.ReducirStock();
                ventas.Add(new Venta(articulo, persona));
                return true;
            }
            return false;
        }

        public Articulo ObtenerArticulo(int posicion)
        {
            return articulos[posicion];
        }

        public void AgregarArticulo(Articulo articulo)
        {
            articulos.Add(articulo);
        }

        public int ObtenerCantidadDeVentas()
        {
            return ventas.Count;
        }

        public int ObtenerMontoDeVentas()
        {
            int monto = 0;
            foreach(Venta venta in ventas)
            {
                monto += venta.ObtenerMontoVenta();
            }
            return monto;
        }

        public string ObtenerDescripcion()
        {
            return $"{nombre} - {direccion}";
        }
    }
}
