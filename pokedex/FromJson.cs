using Newtonsoft.Json;
using pokedex.Models;
using System.Net;

namespace pokedex
{
    public class FromJson
    {
        List<FromJson_Pokemon> pokemon = new List<FromJson_Pokemon>();
        List<Pokemon> pokemons = new List<Pokemon>();

        public FromJson()
        {
            From_Pars();
            To_Pars(pokemon);
        }

        void From_Pars(int ParsCount = 48)
        {
            string json;
            using (var client = new WebClient())
            {
                json = client.DownloadString("https://pokeapi.co/api/v2/pokemon?limit=" + ParsCount + "&offset=0");
            }
            FromJson_Pokemons PokS = JsonConvert.DeserializeObject<FromJson_Pokemons>(json);
            for (int i = 0; i < PokS.Results.Length; i++)
            {
                using (var client = new WebClient())
                {
                    json = client.DownloadString(PokS.Results[i].Url);

                }
                pokemon.Add(JsonConvert.DeserializeObject<FromJson_Pokemon>(json));
            }
        }
        void To_Pars(List<FromJson_Pokemon> Pokemon) { 
        
            for (int i = 0; i < Pokemon.Count; i++)
            {
                pokemons.Add(new Pokemon()
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

        }

    }
}
