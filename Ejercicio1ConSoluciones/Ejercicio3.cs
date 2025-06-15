using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
	public class AsignarTrabajos
	{
		private struct trabajador
		{
			public String nombre { get; set; }
			public int veces { get; set; }
		}

		private List<trabajador> trabajadores;
		private int indiceTrabajadorActual = 0; 
        private int vecesDevuelto = 0; 

		public AsignarTrabajos()
		{
			trabajadores = new List<trabajador>();
			trabajadores.Add(new trabajador() { nombre = "Antonio", veces = 2 });
			trabajadores.Add(new trabajador() { nombre = "Jesús", veces = 1 });
		}

		/// <summary>
		/// Dada la siguiente clase 'AsignarTrabajo', completar el método 'getTrabajadorAsignado',
		/// que no recibe parámetros y que cada vez que se llama debe devolver una cadena con el
		/// nombre de un trabajador de la lista 'trabajadores'. Los trabajadores se devolverán 
		/// en el orden en el que están en la lista y cada trabajador se devuelve un número
		/// de veces en función del parámetros 'veces'. Una vez que se llega al final de la lista,
		/// se vuelve al principio de la misma.
		/// La sintaxis no es importante, puede usarse pseudocódigo, pero la función debe funcionar
		/// con cualquier lista de trabajadores.
		///
		/// Un ejemplo de uso podría ser un botón que muestra por pantalla el trabajador cada
		/// vez que se pulsa. Por ejemplo:
		///
		/// AsignarTrabajos asignar = new AsignarTrabajos();
		/// private void btn_Click() {
		/// 	MessageBox.Show(asignar.getTrabajadorAsignado());
		/// }
		///
		/// Para el código de ejemplo, cada click debe funcionar como la siguiente secuencia:
		/// 1ª click: Antonio
		/// 2ª click: Antonio 
		/// 3ª click: Jesús 
		/// 4ª click: Antonio
		/// 5ª click: Antonio 
		/// 6ª click: Jesús
		/// ...
		/// </summary>
		public String getTrabajadorAsignado()
		{
			if (trabajadores == null || trabajadores.Count == 0)
                return null; 

            trabajador trabajadorActual = trabajadores[indiceTrabajadorActual];
            string nombre = trabajadorActual.nombre;

            vecesDevuelto++; 

            if (vecesDevuelto >= trabajadorActual.veces) 
            {
                vecesDevuelto = 0;
                indiceTrabajadorActual++; 
                if (indiceTrabajadorActual >= trabajadores.Count) 
                {
                    indiceTrabajadorActual = 0; 
                }
            }
            return nombre; 
		}
	}

}
