using Newtonsoft.Json;

namespace pokedex.Models
{
    public class RedBlue
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public Uri BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public Uri FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

}
