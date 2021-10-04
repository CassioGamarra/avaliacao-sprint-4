using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Atividade_3.Models;

namespace Atividade_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        public List<Pokemon> Pokemons;
        [HttpGet]
        public IEnumerable<Pokemon> Get()
        { 
            return Pokemons;
        }
        [HttpPost]
        public string Create([FromBody] Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
            return "Pokemon adicionado com sucesso!";
        }
        [HttpDelete("{codigo}")]
        public string Delete(int codigo) 
        {
            for (int i = 0; i < Pokemons.Count; i++) 
            {
                if (Pokemons[i].Codigo == codigo) 
                {
                    Pokemons.RemoveAt(i);
                }
            }
            return "Pokemon excluído com sucesso!";
        }
    }
}
