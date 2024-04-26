using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace pokedex.Models
{
    [Keyless]
    public class Crystal
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        public Uri BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        public Uri FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

}
