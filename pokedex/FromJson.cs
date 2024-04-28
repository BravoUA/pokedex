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
         
        }
        public static FromJson getInstance()
        {
            if (instance == null)
                instance = new FromJson();
            return instance;
        }
        void From_Pars(int ParsCount = 48)
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


    }
}
