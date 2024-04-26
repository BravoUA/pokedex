using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SQLite;

namespace pokedex.Models
{
    public class FromJson_Pokemon
    {
        [JsonProperty("abilities")]
        public List<abilities> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }
        
        //[JsonProperty("cries")]
       // public Cries Cries { get; set; }
        
        [JsonProperty("forms")]
        public List<Forms> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
        //[JsonProperty("held_items")]
        //public string HeldItems { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        /*
        [JsonProperty("order")]
        public long Order { get; set; }
        */
        [JsonProperty("past_abilities")]
        public string[] PastAbilities { get; set; }
        /*
                [JsonProperty("past_types")]
                public string[] PastTypes { get; set; }
        */
        [ForeignKey("SpeciesID")]
        [JsonProperty("species")]
        public Species Species { get; set; }
        [ForeignKey("SpritesID")]
        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stats> Stats { get; set; }

        [JsonProperty("types")]
        public List<types> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}