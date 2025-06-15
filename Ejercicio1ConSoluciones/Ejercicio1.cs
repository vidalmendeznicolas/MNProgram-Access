using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
	public static class Ejercicio1
	{
		/// <summary>
		/// El método debe eliminar de la lista pasada como primer parámetro aquellos 
		/// elementos en las posiciones indicadas en la segunda lista. Ejemplos:
		/// Ej1. lista = [ 3, 1, 2 ] ; posicionesAEliminar = [ 0, 1, 2 ] => al finalizar, lista = [ ]
		/// Ej2. lista = [ 3, 1, 2 ] ; posicionesAEliminar = [ 0, 1 ] => al finalizar, lista = [ 2 ]
		/// Ej3. lista = [ 3, 1, 2 ] ; posicionesAEliminar = [ 0, 0 ] => al finalizar, lista = [ 1, 2 ]
		/// </summary>
		public static void eliminarPosiciones(List<int> lista, List<int> posicionesAEliminar)
		{
			if (lista == null || lista.Count == 0 || posicionesAEliminar == null || posicionesAEliminar.Count == 0)
				Console.WriteLine("ERROR !!! Las listas de entrada no pueden estar vacías o ser nulas");
			else
			{
				List<int> posiciones = posicionesAEliminar.Distinct().OrderBy(x => x).ToList();
				for (int i = posiciones.Count - 1; i >= 0; i--)
				{
					int indice = posiciones[i];
					if (indice < lista.Count) 
					{
						lista.RemoveAt(indice);
					}
				}
			}
		}
	}
}