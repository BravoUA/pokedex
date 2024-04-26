using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int base_experience { get; set; }
        public List<Stat> Stats { get; set; }
        public string URL_IMG { get; set; }
        public List<abilities> Abilities { get; set; }
        public List<types> Types { get; set; }
    }
}
