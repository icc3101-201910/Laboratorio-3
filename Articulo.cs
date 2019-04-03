using System;
namespace Laboratorio3
{
    public class Articulo
    {
        protected string nombre;
        protected int precio;
        protected int stock;

        public Articulo(string nombre, int precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public bool TieneStock()
        {
            return stock > 0;
        }

        public void ReducirStock() {
            stock -= 1;
        }

        public int ObtenerPrecio() {
            return precio;
        }

        public virtual string ObtenerDescripcion() {
            return "";
        }
    }
}
