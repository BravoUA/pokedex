﻿using Microsoft.EntityFrameworkCore;
using pokedex.Models;

namespace pokedex
{
    public class dbConnect: DbContext
    {


        public DbContext DbContext { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<FromJson_Pokemon> FromJson_Pokemon { get; set; }
        public DbSet<FromJson_Pokemons> FromJson_Pokemons { get; set; }
    /*    public DbSet<abilities> abilities { get; set; }

        public DbSet<ability> ability { get; set; }

        public DbSet<TypeElement> TypeElement { get; set; }
        public DbSet<Species> Species { get; set; }

        public DbSet<GameIndex> GameIndex { get; set; }

        public DbSet<Move> Move { get; set; }
        public DbSet<Sprites> Sprites { get; set; }

        public DbSet<Stat> Stat { get; set; }*/









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
