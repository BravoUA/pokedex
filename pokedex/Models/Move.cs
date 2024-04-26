using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [NotMapped]

    public class Move
    {
        [JsonProperty("move")]
        public Species MoveMove { get; set; }

        [JsonProperty("version_group_details")]
        public VersionGroupDetail[] VersionGroupDetails { get; set; }
    }
}
