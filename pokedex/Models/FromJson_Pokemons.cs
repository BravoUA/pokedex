using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public class FromJson_Pokemons
    {
        [JsonProperty("count")]
        public long Count { get; set; }
        
        [JsonProperty("results")]
        public List<Result> Results { get; set; }
        [Key]
        public int id { get; set; }

    }
}
