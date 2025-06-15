using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
	public static class Ejercicio4
	{
		private readonly int[] precios = { 100, 90, 120, 80, 110, 140, 60, 110 };

		/// <summary>
		/// Dada la lista 'precios', que representa el valor en € de un objeto cada 
		/// día durante un periodo de 8 días, devolver el máximo beneficio en € que 
		/// podemos obtener al comprar el objeto en un día X y venderlo en otro día X + n.
		/// No se puede vender el objeto antes de comprarlo.
		/// </summary>
		public int MaximoBeneficio()
		{
			if (precios.Count() == 0) return 0; 

			int minimoPrecio = precios[0];
			int maximoBeneficio = 0; 

			for (int i = 1; i < precios.Count(); i++) 
			{
				if (precios[i] < minimoPrecio)
					minimoPrecio = precios[i]; 
				else
				{
					int beneficioActual = precios[i] - minimoPrecio; 
					if (beneficioActual > maximoBeneficio)
						maximoBeneficio = beneficioActual; 
				}
			}
			return maximoBeneficio; 
		}
	}
}
