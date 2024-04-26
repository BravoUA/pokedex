using Newtonsoft.Json;
using pokedex.Models;
using System.Net;

namespace pokedex
{
    public class FromJson
    {
        private static FromJson instance;

        public List<FromJson_Pokemon> FromJson_Pokemon = new List<FromJson_Pokemon>();
       public List<Pokemon> pokemon = new List<Pokemon>();
        dbConnect dbConnect;
        private FromJson()
        {
            From_Pars();
            To_Pars(FromJson_Pokemon);
        }
        public static FromJson getInstance()
        {
            if (instance == null)
                instance = new FromJson();
            return instance;
        }
        void From_Pars(int ParsCount = 12)
        {

            string json;
            using (var client = new WebClient())
            {
                json = client.DownloadString("https://pokeapi.co/api/v2/pokemon?limit=" + ParsCount + "&offset=0");
            }
           var PokS = JsonConvert.DeserializeObject<FromJson_Pokemons>(json);
            for (int i = 0; i < PokS.Results.Count; i++)
            {
                using (var client = new WebClient())
                {
                    json = client.DownloadString(PokS.Results[i].Url);

                }
                FromJson_Pokemon.Add(JsonConvert.DeserializeObject<FromJson_Pokemon>(json));
            }

            

            using (dbConnect = new dbConnect())
            {
              
                    dbConnect.FromJson_Pokemon.AddRange(FromJson_Pokemon);
                
                dbConnect.FromJson_Pokemons.Add(PokS);

                dbConnect.SaveChanges();
            }
        }
        void To_Pars(List<FromJson_Pokemon> Pokemon) { 
        
            for (int i = 0; i < Pokemon.Count; i++)
            {
                pokemon.Add(new Pokemon()
                {
                    Name = Pokemon[i].Name,
                    base_experience = (int)Pokemon[i].BaseExperience,
                    Stats = Pokemon[i].Stats,
                    URL_IMG = Pokemon[i].Sprites.Other.Home.FrontDefault.ToString(),
                    ID_POK = (int)Pokemon[i].Id,
                    Abilities = Pokemon[i].Abilities,
                    Types = Pokemon[i].Types
                }) ;
            }
            
            using (dbConnect = new dbConnect()) {
                dbConnect.Pokemon.AddRange(pokemon);
                dbConnect.SaveChanges();
            }
        }

    }
}
