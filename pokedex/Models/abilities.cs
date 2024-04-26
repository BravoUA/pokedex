using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace pokedex.Models
{

    
    public class abilities
    {
        [ForeignKey("AbilityId")]
        [JsonProperty("ability")]
        public ability ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }
        [Key]
        public int abilitiesID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
       

    }
    public class ability {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        [Key]
        public int abilityID { get; set; }
      
        public abilities abilities { get; set; }


    }
}
