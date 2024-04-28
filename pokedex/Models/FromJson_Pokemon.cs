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
        public List<abilities> abilities { get; set; }

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
        public List<string> PastAbilities { get; set; }
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
        public List<types> types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
    public class abilities
    {
        [ForeignKey("abilityID")]
        [JsonProperty("ability")]
        public ability ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        public int abilitiesID { get; set; }

        public FromJson_Pokemon FromJson_Pokemon { get; set; }


    }
    public class ability
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
        public int abilityID { get; set; }

        public abilities abilities { get; set; }


    }
    public class Sprites
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string? FrontShinyFemale { get; set; }

        [ForeignKey("OtherId")]
        [JsonProperty("other")]
        public Other Other { get; set; }

        [ForeignKey("VersionsId")]
        [JsonProperty("versions")]
        public Versions Versions { get; set; }


        public int SpritesID { get; set; }
        public FromJson_Pokemon FromJson_Pokemon { get; set; }

    }
    public class Other
    {

        [ForeignKey("HomeId")]
        [JsonProperty("home")]
        public Home Home { get; set; }

        [ForeignKey("DreamWorldId")]
        [JsonProperty("dream_world")]
        public DreamWorld DreamWorld { get; set; }

        [ForeignKey("OfficialArtworkId")]
        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }


        [ForeignKey("showdownId")]
        [JsonProperty("showdown")]
        public showdown Showdown { get; set; }

        public int OtherId { get; set; }
        public Sprites Sprites { get; set; }
    }
    public class Home
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int HomeId { get; set; }
        public Other Other { get; set; }
    }
    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
        public int OfficialArtworkId { get; set; }
        public Other Other { get; set; }
    }
    public class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? front_female { get; set; }
        public int DreamWorldId { get; set; }
        public Other Other { get; set; }
    }
    public class showdown
    {
        [JsonProperty("back_default")]
        public Uri back_default { get; set; }

        [JsonProperty("back_female")]
        public Uri? back_female { get; set; }

        [JsonProperty("back_shiny")]
        public Uri back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public Uri front_default { get; set; }

        [JsonProperty("front_female")]
        public Uri? front_female { get; set; }

        [JsonProperty("front_shiny")]
        public Uri front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? front_shiny_female { get; set; }

        public int showdownId { get; set; }
        public Other Other { get; set; }
    }
}