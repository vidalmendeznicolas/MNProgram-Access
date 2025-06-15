using System;

namespace Ejercicio.Modelo.Entidades
{
	public class libro : IEntidad
	{
		public int id { get; set; }
		public string titulo { get; set; }

		public libro(String titulo)
		{
			this.titulo = titulo;
		}
	}
}
