using Newtonsoft.Json;

namespace pokedex.Models
{
    public class GenerationV
    {
        [JsonProperty("black-white")]
        public Sprites BlackWhite { get; set; }
    }
}
