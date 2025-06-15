using System;

namespace Ejercicio.Modelo.Entidades
{
    public class revista : IEntidad
    {
        public int id { get; set; }
        public string titulo { get; set; }

        public revista(String titulo)
        {
            this.titulo = titulo;
        }
    }
}
