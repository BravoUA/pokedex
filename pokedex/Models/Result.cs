using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace pokedex.Models
{
    public class Result
    {

        [JsonProperty("name")]
        public string Name { get; set; }
        [Key]
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
