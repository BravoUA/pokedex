using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    

    public class Stats
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public int Effort { get; set; }

        [JsonProperty("stat")]
        [ForeignKey("StatID")]
        public Stat Stat { get; set; }
        public int StatsID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }
    }
    public class Stat {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int StatID { get; set; }
        public Stats Stats { get; set; }
    }

}
