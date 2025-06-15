using Ejercicio.Modelo.Entidades;
using Ejercicio.Modelo.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace MNAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MNController: Controller
    {
        //private static object lock = new object();
        public const string litEntLibro = "LIBROS";
        public const string litEntPelicula = "PELICULAS";
        public const string litEntRevista = "REVISTAS";


        [HttpGet("GetInformeAsync")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public ActionResult<string> GetInformeAsync()
        {
            try
            {
                return Ok(Registro.MostrarInforme());
            }
            catch (Exception ex)
            {
                return BadRequest(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                GC.Collect();
            }
        }


        [HttpGet("GetAddListaAsync/{parTipo}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public ActionResult<bool> GetAddListaAsync(string parTipo)
        {
            bool status = false;
            try
            {
                switch (parTipo)
                {
                    case litEntLibro:
                        ServicioLibros.Crear(new libro("Libro " + new Random().Next(99999)));
                        status = true;
                        break;

                    case litEntPelicula:
                        ServicioPeliculas.Crear(new pelicula("pelicula " + new Random().Next(99999), new Random().Next(1900, 2024)));
                        status = true;
                        break;

                    case litEntRevista:
                        ServicioRevistas.Crear(new revista("Revista " + new Random().Next(99999)));
                        status = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                return BadRequest(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                GC.Collect();
            }
            return Ok(status);
        }

        [HttpGet("GetBajaListaAsync/{parTipo},{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public ActionResult<bool> GetBajaListaAsync(string parTipo, int id)
        {
            bool status = false;
            try
            {
                switch (parTipo)
                {
                    case litEntLibro:
                        ServicioLibros.Eliminar(id);
                        status = true;
                        break;

                    case litEntPelicula:
                        ServicioPeliculas.Eliminar(id);
                        status = true;
                        break;

                    case litEntRevista:
                        ServicioRevistas.Eliminar(id);
                        status = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                return BadRequest(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                GC.Collect();
            }
            return Ok(status);
        }


        [HttpGet("GetListaAsync/{parTipo}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<object>))]
        public ActionResult<List<object>> GetListaAsync(string parTipo)
        {
            try
            {
                switch (parTipo)
                {
                    case litEntLibro:
                        return Ok(ServicioLibros.getLibros());

                    case litEntPelicula:
                        return Ok(ServicioPeliculas.getPeliculas());

                    case litEntRevista:
                        return Ok(ServicioRevistas.getRevistas());
                    default:
                        return Ok(new List<int> { });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                GC.Collect();
            }
        }


        [HttpGet("GetListaFiltradaAsync/{parTipo},{parTexto}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<object>))]
        public ActionResult<List<object>> GetListaFiltradaAsync(string parTipo, string parTexto)
        {
            try
            {
                switch (parTipo)
                {
                    case litEntLibro:
                        return Ok(ServicioLibros.Filtrar(parTexto));

                    case litEntPelicula:
                        return Ok(ServicioPeliculas.Filtrar(parTexto));

                    case litEntRevista:
                        return Ok(ServicioRevistas.Filtrar(parTexto));
                    default:
                        return Ok(new List<string> { });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(string.Format("Error: {0}", ex.Message));
            }
            finally
            {
                GC.Collect();
            }
        }


    }
}
