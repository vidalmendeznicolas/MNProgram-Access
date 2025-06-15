using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Ejercicio;
using Ejercicio.Modelo.Entidades;
using Newtonsoft.Json;

namespace Ejercicio.Modelo.Servicios
{
    public class ApiCliente
    {
        private readonly HttpClient _client;

        public ApiCliente()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7102/")
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> ComprobarConexion()
        {
            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/ComprobarConexion");
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(resultString);
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }

        public async Task<bool> GetAddListaAsync(string parTipo)
        {

            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/GetAddListaAsync/" + parTipo);
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(resultString);
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }
        public async Task<bool> GetBajaListaAsync(string parTipo, int id)
        {

            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/GetBajaListaAsync/" + parTipo +"," + id);
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(resultString);
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }

        public async Task<string> GetInformeAsync()
        {

            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/GetInformeAsync/");
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<string>(resultString);
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }

        public async Task<List<object>> GetListaAsync(string parTipo)
        {

            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/GetListaAsync/" + parTipo);
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                switch (parTipo)
                {
                    case frmPrincipal.litEntLibro:
                        return JsonConvert.DeserializeObject<List<libro>>(resultString).Cast<object>().ToList();

                    case frmPrincipal.litEntPelicula:
                        return JsonConvert.DeserializeObject<List<pelicula>>(resultString).Cast<object>().ToList();

                    case frmPrincipal.litEntRevista:
                        return JsonConvert.DeserializeObject<List<revista>>(resultString).Cast<object>().ToList();
                    default:
                        return new List<object> { };
                }
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }

        public async Task<List<object>> GetListaFiltradaAsync(string parTipo, string parTexto)
        {

            HttpResponseMessage response = await _client.GetAsync($"https://localhost:7102/MN/GetListaFiltradaAsync/" + parTipo + "," + parTexto);
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                switch (parTipo)
                {
                    case frmPrincipal.litEntLibro:
                        return JsonConvert.DeserializeObject<List<libro>>(resultString).Cast<object>().ToList();

                    case frmPrincipal.litEntPelicula:
                        return JsonConvert.DeserializeObject<List<pelicula>>(resultString).Cast<object>().ToList();

                    case frmPrincipal.litEntRevista:
                        return JsonConvert.DeserializeObject<List<revista>>(resultString).Cast<object>().ToList();
                    default:
                        return new List<object> { };
                }
            }
            else
            {
                throw new Exception($"Failed to call the API: {response.StatusCode}");
            }
        }     


    }
}
