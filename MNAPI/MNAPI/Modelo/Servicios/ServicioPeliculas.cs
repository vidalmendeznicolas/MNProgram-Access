using Ejercicio.Modelo.DAO;
using Ejercicio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio.Modelo.Servicios
{
	public static class ServicioPeliculas
	{
        public static List<pelicula> getPeliculas()
        {
            return GenericDAO<pelicula>.getElementos();
        }

        public static List<pelicula> Filtrar(string parTexto)
        {
            return GenericDAO<pelicula>.getElementos().Where(x => x.titulo.Contains(parTexto)).ToList();
        }

        public static int Crear(pelicula pelicula)
		{
            int id = GenericDAO<pelicula>.Crear(pelicula);
            Registro.ActualizarInforme("Operación Crear Entidad Pelicula con id -> " + pelicula.id + "\n");
            return id;
		}

		public static pelicula Buscar(int id)
		{
            Registro.ActualizarInforme("Operación Buscar Entidad Pelicula con id -> " + id + "\n");
            return GenericDAO<pelicula>.Buscar(id);
		}

		public static void Actualizar(pelicula pelicula)
		{
            Registro.ActualizarInforme("Operación Actualizar Entidad Pelicula con id -> " + pelicula.id + "\n");
            GenericDAO<pelicula>.Actualizar(pelicula);
		}

		public static void Eliminar(int id)
		{
            Registro.ActualizarInforme("Operación Eliminar Entidad Pelicula con id -> " + id + "\n");
            GenericDAO<pelicula>.Eliminar(id);
		}
	}
}
