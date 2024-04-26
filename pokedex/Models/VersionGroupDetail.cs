using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using static pokedex.Models.MoveLearnMethod;

namespace pokedex.Models
{
    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [ForeignKey("MoveLearnMethodId")]
        [JsonProperty("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }

        
        public int VersionGroupDetailId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int MoveLearnMethodID { get; set; }
        [ForeignKey("VersionGroupDetailId")]
        public VersionGroupDetail VersionGroupDetail { get; set; }

        public class VersionGroup
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
          
            public int VersionGroupID { get; set; }
            [ForeignKey("VersionGroupDetailId")]
            public VersionGroupDetail VersionGroupDetail { get; set; }
        }
    }
}
