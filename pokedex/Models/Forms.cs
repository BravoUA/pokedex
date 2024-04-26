using Newtonsoft.Json;

namespace pokedex.Models
{
    public class Forms
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int FormsID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
    }
}
