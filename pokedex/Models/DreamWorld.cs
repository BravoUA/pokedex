using Newtonsoft.Json;

namespace pokedex.Models
{
    public class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }
    }

}
