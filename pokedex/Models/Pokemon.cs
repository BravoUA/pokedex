namespace pokedex.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int base_experience { get; set; }
        public List<Stat> Stats { get; set; }
        public string URL_IMG { get; set; }
        public int ID_POK { get; set; }
        public List<abilities> Abilities { get; set; }
        public List<TypeElement> Types { get; set; }
    }
}
