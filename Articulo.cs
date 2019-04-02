using System;
namespace Laboratorio3
{
    public class Articulo
    {
        protected string nombre;
        protected int precio;
        protected int stock;

        public Articulo()
        {
        }

        public bool TieneStock()
        {
            return false;
        }

        public void ReducirStock() {

        }

        public int ObtenerPrecio() {
            return 0;
        }

        public virtual string ObtenerDescripcion() {
            return "";
        }
    }
}
