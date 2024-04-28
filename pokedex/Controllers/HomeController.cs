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
        List<ability> ability = new List<ability>();
        List<abilities> abilities = new List<abilities>();
        List<Sprites> sprites = new List<Sprites>();
        List<Other> other = new List<Other>();  
        List<Home> homes = new List<Home>();
        List<FromJson_Pokemon> Poke = new List<FromJson_Pokemon>();
        dbConnect dbConnect;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int pg = 1)
        {
          FromJson.getInstance();

            using (dbConnect = new dbConnect()) {
                abilities = dbConnect.abilities.ToList();
                Poke = dbConnect.FromJson_Pokemon.ToList();
                ability = dbConnect.ability.ToList();
                sprites = dbConnect.Sprites.ToList();
                other = dbConnect.Other.ToList();
                homes = dbConnect.Home.ToList();
            }

           

            int pageSize = 12;
            if (pg < 1) pg = 1;

            int pocCount = Poke.Count;
            var pager = new Page(pocCount,pg,pageSize);
            int recSkin = (pg - 1) * pageSize;
            var data = Poke.Skip(recSkin).Take(pager.PageSize).ToList();
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
