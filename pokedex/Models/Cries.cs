using Newtonsoft.Json;

namespace pokedex.Models
{
    public class Cries
    {
        [JsonProperty("latest")]
        public Uri Latest { get; set; }

        [JsonProperty("legacy")]
        public Uri Legacy { get; set; }
    }
}
