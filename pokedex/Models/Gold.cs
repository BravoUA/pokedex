using Newtonsoft.Json;

namespace pokedex.Models
{
    public class Gold
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public Uri FrontTransparent { get; set; }
    }

}
