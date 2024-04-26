using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using pokedex.Models;
using System.ComponentModel.DataAnnotations;

namespace pokedex.Models
{
    public class GenerationIi
    {
        [JsonProperty("crystal")]
        public Crystal Crystal { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("silver")]
        public Gold Silver { get; set; }
    }

}
