using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
	public static class Ejercicio2
	{
		public static int variable { get; set; }

		private static int métodoAuxiliar()
		{ 
			System.Threading.Thread.Sleep(1000); //Simulamos lentitud en la ejecución: 1 segundo de espera
			return DateTime.Now.Day - 15;  
		}

		/// <summary>
		/// Sin modificar el contenido de métodoAuxiliar(), optimizar lo máximo posible el siguiente método
		/// </summary>
		public static void método()
		{
            int result = métodoAuxiliar();
            if (result < 0)
                variable = -1;
            else
                variable = result != 0 ? 1 : 0;
		}
	}
}
