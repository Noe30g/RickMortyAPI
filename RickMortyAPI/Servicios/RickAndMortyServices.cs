using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickMortyAPI.Modelo;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace RickMortyAPI.Servicios
{
    public class RickAndMortyServices : IRickAndMortyServices
    {
        private string UrlApi = "https://rickandmortyapi.com/api/character";
        public async Task<List<PersonajesResponse>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(UrlApi);
            var responseBody = await response.Content.ReadAsStringAsync();

            JsonNode nodos= JsonNode.Parse(responseBody);

            JsonNode results = nodos["results"];

            var personajeData = JsonSerializer.Deserialize<List<PersonajesResponse>>(results.ToString());
            return personajeData;

        }

    }
}
