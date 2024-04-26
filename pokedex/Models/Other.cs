using Newtonsoft.Json;
using pokedex.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public class Other
    {

        [ForeignKey("HomeId")]
        [JsonProperty("home")]
        public Home Home { get; set; }
        [ForeignKey("DreamWorldId")]
        [JsonProperty("dream_world")]
        public DreamWorld DreamWorld { get; set; }
        [ForeignKey("OfficialArtworkId")]
        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }


        [ForeignKey("showdownId")]
        [JsonProperty("showdown")]
        public showdown Showdown { get; set; }

        public  int OtherId { get; set; }
        public Sprites Sprites { get; set; }
    }
    public class Home
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public  int HomeId { get; set; }
        public Other Other { get; set; }
    }
    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
        public int OfficialArtworkId { get; set; }
        public Other Other { get; set; }
    }
    public class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? front_female { get; set; }
        public int DreamWorldId { get; set; }
        public Other Other { get; set; }
    }
    public class showdown
    {
        [JsonProperty("back_default")]
        public Uri back_default { get; set; }

        [JsonProperty("back_female")]
        public Uri back_female { get; set; }

        [JsonProperty("back_shiny")]
        public Uri back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public Uri front_default { get; set; }

        [JsonProperty("front_female")]
        public Uri? front_female { get; set; }

        [JsonProperty("front_shiny")]
        public Uri front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? front_shiny_female { get; set; }

        public int showdownId { get; set; }
        public Other Other { get; set; }
    }


}
