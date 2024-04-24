namespace pokedex.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int base_experience { get; set; }
        public Stat[] Stats { get; set; }
        public string URL_IMG { get; set; }
        public int ID_POK { get; set; }
        public Ability[] Abilities { get; set; }
        public TypeElement[] Types { get; set; }
    }
}
