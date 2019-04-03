using System;
namespace Laboratorio3
{
    public class Libro : Articulo
    {
        private string autor;

        public Libro(string nombre, int precio, int stock, string autor) : base(nombre, precio, stock)
        {
            this.autor = autor;
        }

        public override string ObtenerDescripcion()
        {
            return $"{nombre} - ({autor})";
        }
    }
}
