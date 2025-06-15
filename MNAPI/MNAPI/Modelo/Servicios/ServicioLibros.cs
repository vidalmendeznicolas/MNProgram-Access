using Ejercicio.Modelo.DAO;
using Ejercicio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio.Modelo.Servicios
{
	public static class ServicioLibros
	{
		public static List<libro> getLibros()
		{
			return GenericDAO<libro>.getElementos();
		}

        public static List<libro> Filtrar(string parTexto)
        {
			var lista = GenericDAO<libro>.getElementos().Where(x => x.titulo.Contains(parTexto)).ToList();
            return GenericDAO<libro>.getElementos().Where(x => x.titulo.Contains(parTexto)).ToList();
        }

        public static int Crear(libro libro)
		{
			int id = GenericDAO<libro>.Crear(libro);
            Registro.ActualizarInforme("Operación Crear Entidad Libro con id -> " + libro.id + "\n");
			return id;
        }

		public static libro Buscar(int id)
		{
            Registro.ActualizarInforme("Operación Buscar Entidad Libro con id -> " + id + "\n");
            return GenericDAO<libro>.Buscar(id);
		}

		public static void Actualizar(libro libro)
		{
            Registro.ActualizarInforme("Operación Actualizar Entidad Libro con id -> " + libro.id + "\n");
            GenericDAO<libro>.Actualizar(libro);
		}

		public static void Eliminar(int id)
		{
            Registro.ActualizarInforme("Operación Eliminar Entidad Libro con id -> " + id + "\n");
            GenericDAO<libro>.Eliminar(id);
		}
	}
}
