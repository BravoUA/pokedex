using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using static pokedex.Models.MoveLearnMethod;

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
    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [ForeignKey("MoveLearnMethodID")]
        [JsonProperty("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }

        [ForeignKey("VersionGroupID")]
        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }

        public int VersionGroupDetailId { get; set; }
        public Move Move { get; set; }

    }
    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int MoveLearnMethodID { get; set; }

        public VersionGroupDetail VersionGroupDetail { get; set; }
    }
    public class VersionGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        public int VersionGroupID { get; set; }

        public VersionGroupDetail VersionGroupDetail { get; set; }
    }

}
