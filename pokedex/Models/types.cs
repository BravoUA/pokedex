using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public class types
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [ForeignKey("TypeID")]
        [JsonProperty("type")]
        public Type Type { get; set; }
        public int typesID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }

    }
    public class Type
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int TypeID { get; set; }
        public types types { get; set; }
    }
}
