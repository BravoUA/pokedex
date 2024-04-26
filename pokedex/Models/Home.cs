using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace pokedex.Models
{
    [Keyless]

    public class Home
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

}
