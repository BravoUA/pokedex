using Newtonsoft.Json;

namespace pokedex.Models
{
    public class Cries
    {
        [JsonProperty("latest")]
        public Uri Latest { get; set; }

        [JsonProperty("legacy")]
        public Uri Legacy { get; set; }

        public int CriesID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
    }
}
