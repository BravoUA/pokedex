using Microsoft.AspNetCore.Mvc;
using pokedex.Models;
using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using System.Numerics;

namespace pokedex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<FromJson_Pokemon> pokemon = new List<FromJson_Pokemon>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int pg = 1)
        {
            string json;
            using (var client = new WebClient())
            {
                json = client.DownloadString("https://pokeapi.co/api/v2/pokemon?limit=48&offset=0");
            }
             List<FromJson_Pokemons> pokemons = new List<FromJson_Pokemons>();
            FromJson_Pokemons PokS = JsonConvert.DeserializeObject<FromJson_Pokemons>(json);
            for (int i = 0; i < PokS.Results.Length; i++)
            {
                using (var client = new WebClient())
                {
                    json = client.DownloadString(PokS.Results[i].Url);
                    
                }
                 pokemon.Add(JsonConvert.DeserializeObject<FromJson_Pokemon>(json));
            }

            int pageSize = 12;
            if (pg < 1) pg = 1;

            int pocCount = pokemon.Count;
            var pager = new Page(pocCount,pg,pageSize);
            int recSkin = (pg - 1) * pageSize;
            var data = pokemon.Skip(recSkin).Take(pager.PageSize).ToList();
            ViewBag.Pager = pager;
            return View(data);
        }













        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
