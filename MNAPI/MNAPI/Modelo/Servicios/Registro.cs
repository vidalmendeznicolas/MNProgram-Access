using Ejercicio.Modelo.DAO;
using Ejercicio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Modelo.Servicios
{
    public static class Registro
    {
        public static string informe;
        public static void ActualizarInforme(string parTexto)
        {
            informe += parTexto;
        }

        public static string MostrarInforme()
        {
            return informe;
        }
    }
}
