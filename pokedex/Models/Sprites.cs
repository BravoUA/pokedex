using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [NotMapped]

    public class Sprites
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
        

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public Other Other { get; set; }
        /*
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public Versions Versions { get; set; }
        */
        [JsonProperty("animated", NullValueHandling = NullValueHandling.Ignore)]
        public Sprites Animated { get; set; }
    }

}
