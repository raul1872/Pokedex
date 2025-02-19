using System.Net.Http.Json;
using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Util
{
    public class PokeClient
    {
        public HttpClient Client { get; set; }

        public PokeClient(HttpClient client)
        {
            Client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pokemon>(content);
        }

        public async Task<List<PokemonBasic>> GetAllPokemonNames()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://pokeapi.co/api/v2/pokemon?limit=10000"; 
                var response = await client.GetFromJsonAsync<PokemonListResponse>(url);
                return response?.Results ?? new List<PokemonBasic>();
            }
        }

        public class PokemonListResponse
        {
            public List<PokemonBasic> Results { get; set; }
        }

        public class PokemonBasic
        {
            public string name { get; set; }
        }
    }
}
