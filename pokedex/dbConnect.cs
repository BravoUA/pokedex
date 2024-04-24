using Microsoft.EntityFrameworkCore;
using pokedex.Models;

namespace pokedex
{
    public class dbConnect: DbContext
    {


        public DbContext DbContext { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }


        public dbConnect()
        {

        }
        public dbConnect(DbContextOptions<dbConnect> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
