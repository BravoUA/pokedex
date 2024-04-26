using Newtonsoft.Json;
using pokedex.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace pokedex.Models
{
    public class Versions
    {
        [ForeignKey("GenerationIId")]
        [JsonProperty("generation-i")]
        public GenerationI GenerationI { get; set; }
        [ForeignKey("GenerationiiId")]
        [JsonProperty("generation-ii")]
        public Generationii Generationii { get; set; }
        [ForeignKey("GenerationIiiId")]
        [JsonProperty("generation-iii")]
        public GenerationIii GenerationIii { get; set; }
        [ForeignKey("GenerationIvId")]
        [JsonProperty("generation-iv")]
        public GenerationIv GenerationIv { get; set; }
        [ForeignKey("GenerationVId")]
        [JsonProperty("generation-v")]
        public GenerationV GenerationV { get; set; }
        [ForeignKey("GenerationViId")]
        [JsonProperty("generation-vi")]
        public GenerationVi GenerationVi { get; set; }
        [ForeignKey("GenerationViiId")]
        [JsonProperty("generation-vii")]
        public GenerationVii GenerationVii { get; set; }
        [ForeignKey("GenerationViiiId")]
        [JsonProperty("generation-viii")]
        public GenerationViii GenerationViii { get; set; }
        public int VersionsId { get; set; }
        public Sprites Sprites { get; set; }
    }
    public  class GenerationI
    {
        [JsonProperty("red-blue")]
        [ForeignKey("RedBlueId")]
        public RedBlue RedBlue { get; set; }

        [ForeignKey("yellowId")]
        [JsonProperty("yellow")]
        public yellow Yellow { get; set; }

        public int GenerationIId { get; set; }
        public Versions Versions { get; set; }
    }
    public class Generationii
    {
        [ForeignKey("CrystalId")]
        [JsonProperty("crystal")]
        public Crystal Crystal { get; set; }
        [ForeignKey("GoldlId")]
        [JsonProperty("gold")]
        public Gold Gold { get; set; }
        [ForeignKey("SilverId")]
        [JsonProperty("silver")]
        public Silver Silver { get; set; }
        public int GenerationiiId { get; set; }
        public Versions Versions { get; set; }

    }
    public class GenerationIii
    {
        [ForeignKey("EmeraldId")]
        [JsonProperty("emerald")]
        public Emerald Emerald { get; set; }
        [ForeignKey("FireredLeafgreenId")]
        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen FireredLeafgreen { get; set; }

        [ForeignKey("RubySapphireId")]
        [JsonProperty("ruby-sapphire")]
        public RubySapphire RubySapphire { get; set; }
        public int GenerationIiiId { get; set; }
        public Versions Versions { get; set; }
    }
    public class GenerationIv
    {
        [ForeignKey("DiamondPearlId")]
        [JsonProperty("diamond-pearl")]
        public DiamondPearl DiamondPearl { get; set; }
        [ForeignKey("HeartgoldSoulsilverId")]
        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
        [ForeignKey("PlatinumId")]
        [JsonProperty("platinum")]
        public Platinum Platinum { get; set; }
        public int GenerationIvId { get; set; }
        public Versions Versions { get; set; }
    }
    public class GenerationVi
    {
        [ForeignKey("OmegarubyAlphasapphireId")]
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }
        [ForeignKey("XYId")]
        [JsonProperty("x-y")]
        public XY XY { get; set; }
        public int GenerationViId { get; set; }
        public Versions Versions { get; set; }
    }
    public class GenerationV
    {
        [ForeignKey("BlackWhited")]

        [JsonProperty("black-white")]
        public BlackWhite BlackWhite { get; set; }
        public int GenerationVId { get; set; }
        public Versions Versions { get; set; }
    }
    public class GenerationVii
    {
        [ForeignKey("IconsId")]
        [JsonProperty("icons")]
        public Icons Icons { get; set; }
        [ForeignKey("UltraSunUltraMoonId")]
        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
        public int GenerationViiId { get; set; }
        public Versions Versions { get; set; }
    }
    public partial class GenerationViii
    {
        //  [JsonProperty("icons")]
        //  public Icons Icons { get; set; }
        public int GenerationViiiId { get; set; }
        public Versions Versions { get; set; }
    }

    public class RedBlue
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public Uri BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public Uri FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
        public  int RedBlueId { get; set; }
        public GenerationI GenerationI { get; set; }
    }
    public class yellow {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public Uri BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public Uri FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
        public  int  yellowId { get; set; }
        public GenerationI GenerationI { get; set; }
    }
   
    public class Crystal
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        public Uri BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        public Uri FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
        public  int CrystalId { get; set; }
        public Generationii Generationii { get; set; }
    }
    public class Gold
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
        public int GoldId { get; set; }
        public Generationii Generationii { get; set; }
    }
    public  class Silver
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_transparent")]
        public Uri FrontTransparent { get; set; }
        public int SilverId { get; set; }
        public Generationii Generationii { get; set; }
    }
 
    public  class Emerald
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
        public int EmeraldId { get; set; }
        public GenerationIii GenerationIii { get; set; }
    }
    public  class FireredLeafgreen
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
        public int FireredLeafgreenId { get; set; }
        public GenerationIii GenerationIii { get; set; }
    }
    public partial class RubySapphire
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
        public int RubySapphireId { get; set; }
        public GenerationIii GenerationIii { get; set; }
    }

    public  class DiamondPearl
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public Uri? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int DiamondPearlId { get; set; }
        public GenerationIv GenerationIv { get; set; }
    }
    public  class HeartgoldSoulsilver
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public Uri? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int HeartgoldSoulsilverId { get; set; }
        public GenerationIv GenerationIv { get; set; }
    }
    public  class Platinum
    {
        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public Uri? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int PlatinumId { get; set; }
        public GenerationIv GenerationIv { get; set; }
    }
   
    public  class BlackWhite
    {
        [ForeignKey("AnimatedId")]
        [JsonProperty("animated")]
        public Animated Animated { get; set; }

        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public Uri? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int BlackWhiteId { get; set; }
        public GenerationV GenerationV { get; set; }
    }
    public class Animated {

        [JsonProperty("back_default")]
        public Uri BackDefault { get; set; }

        [JsonProperty("back_female")]
        public Uri? BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public Uri? BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }

        public int AnimatedId { get; set; }
        public BlackWhite BlackWhite { get; set; }
    }
    
    public class OmegarubyAlphasapphire
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int OmegarubyAlphasapphireId { get; set; }
        public GenerationVi GenerationVi { get; set; }
    }
    public class XY
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int XYId { get; set; }
        public GenerationVi GenerationVi { get; set; }
    }
   
    public class Icons
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string? FrontFemale { get; set; }
        public int IconsId { get; set; }
        public GenerationVii GenerationVii { get; set; }
    }
    public class UltraSunUltraMoon
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public Uri? FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public Uri? FrontShinyFemale { get; set; }
        public int UltraSunUltraMoonId { get; set; }
        public GenerationVii GenerationVii { get; set; }
    }
    


}
