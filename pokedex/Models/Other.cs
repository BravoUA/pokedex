using Newtonsoft.Json;
using pokedex.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [NotMapped]
    public class Other
    {
        

        [JsonProperty("home")]
        public Home Home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
        [ForeignKey("Sprites")]

        [JsonProperty("showdown")]
        public Sprites Showdown { get; set; }
    }

}
