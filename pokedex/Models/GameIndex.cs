using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [NotMapped]
    public class GameIndex
    {
        [JsonProperty("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
