using System;
namespace Laboratorio3
{
    public class Persona
    {
        private string rut;

        public Persona(string rut)
        {
            this.rut = rut;
        }

        public string ObtenerDescripcion()
        {
            return rut;
        }
    }
}
