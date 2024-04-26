using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{


    public class Move
    {
        [JsonProperty("move")]
        public MoveMove MoveMove { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }



        public int MoveID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
    }
    public class MoveMove {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int MoveMoveID { get; set; }
        public Move Move { get; set; }
    }
}
