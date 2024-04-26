using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    
    public class Sprites
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string? FrontShinyFemale { get; set; }

        [ForeignKey("OtherId")]
        [JsonProperty("other")]
        public Other Other { get; set; }
        [ForeignKey("VersionsId")]
        [JsonProperty("versions")]
        public Versions Versions { get; set; }
        

        public int SpritesID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }

    }

}
