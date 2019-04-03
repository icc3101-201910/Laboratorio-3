using System;

namespace Laboratorio3
{
    public class Juego : Articulo
    {
        private string plataforma;

        public Juego(string nombre, string plataforma, int precio, int stock) : base(nombre, precio, stock)
        {
            this.plataforma = plataforma;
        }

        public override string ObtenerDescripcion()
        {
            return $"{nombre} - ({plataforma})";
        }
    }
}
