using System;
namespace Laboratorio3
{
    public class Venta
    {
        private Articulo articuloVendido;
        private Persona comprador;

        public Venta(Articulo articulo, Persona persona)
        {
            articuloVendido = articulo;
            comprador = persona;
        }

        public string ObtenerDescripcion()
        {
            return $"{articuloVendido.ObtenerPrecio()} - {articuloVendido.ObtenerDescripcion()} - {comprador.ObtenerDescripcion()}";
        }

        public int ObtenerMontoVenta()
        {
            return articuloVendido.ObtenerPrecio();
        }
    }
}
