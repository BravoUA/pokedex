using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public class GameIndex
    {
        [JsonProperty("game_index")]
        public int game_index { get; set; }

        [ForeignKey("VersionID")]
        [JsonProperty("version")]
        public Version Version { get; set; }
        public int GameIndexID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
    }
    public class Version {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int VersionID { get; set; }
        public GameIndex GameIndex { get; set; }
    }
}
