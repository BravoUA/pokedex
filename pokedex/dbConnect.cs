using Microsoft.EntityFrameworkCore;
using pokedex.Models;
using Type = pokedex.Models.Type;

namespace pokedex
{
    public class dbConnect: DbContext
    {


        public DbContext DbContext { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<FromJson_Pokemon> FromJson_Pokemon { get; set; }
        public DbSet<FromJson_Pokemons> FromJson_Pokemons { get; set; }
        
        public DbSet<abilities> abilities { get; set; }

        public DbSet<ability> ability { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<Other> Other { get; set; }

        public DbSet<Home> Home { get; set; }
        public DbSet<Sprites> Sprites { get; set; }

        public DbSet<Stat> Stat { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<types> types { get; set; }

        








        public dbConnect()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Filename=TEST.db");

        }

    }
}
