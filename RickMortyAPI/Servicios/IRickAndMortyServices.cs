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
    public interface IRickAndMortyServices 
    {
        public Task<List<PersonajesResponse>> Obtener();
    }
}
