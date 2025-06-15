using Ejercicio.Modelo.DAO;
using Ejercicio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio.Modelo.Servicios
{
    public static class ServicioRevistas
    {

        public static List<revista> getRevistas()
        {
            return GenericDAO<revista>.getElementos();
        }
        public static List<revista> Filtrar(string parTexto)
        {
            return GenericDAO<revista>.getElementos().Where(x => x.titulo.Contains(parTexto)).ToList();
        }
        public static int Crear(revista revista)
        {
            int id = GenericDAO<revista>.Crear(revista);
            Registro.ActualizarInforme("Operación Crear Entidad Revista con id -> " + revista.id + "\n");
            return id;
        }

        public static revista Buscar(int id)
        {
            Registro.ActualizarInforme("Operación Buscar Entidad Revista con id -> " + id + "\n");
            return GenericDAO<revista>.Buscar(id);
        }

        public static void Actualizar(revista revista)
        {
            Registro.ActualizarInforme("Operación Actualizar Entidad Revista con id -> " + revista.id + "\n");
            GenericDAO<revista>.Actualizar(revista);
        }

        public static void Eliminar(int id)
        {
            Registro.ActualizarInforme("Operación Eliminar Entidad Revista con id -> " + id + "\n");
            GenericDAO<revista>.Eliminar(id);
        }
    }
}
