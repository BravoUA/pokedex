using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace pokedex.Models
{
    [NotMapped]

    public class abilities
    {

        [JsonProperty("ability")]
        public ability Abilitys { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
        [Key]
        [JsonProperty("slot")]
        public long Slot { get; set; }
    }
    public class ability {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }


    }
}
