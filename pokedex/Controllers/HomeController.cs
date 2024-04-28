using Microsoft.AspNetCore.Mvc;
using pokedex.Models;
using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using System.Numerics;
using Type = pokedex.Models.Type;
using System.Data;

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
        List<types> types = new List<types>();

        List<Type> Type = new List<Type>();

        List<FromJson_Pokemon> Poke = new List<FromJson_Pokemon>();
        List<FromJson_Pokemon> Poke2 = new List<FromJson_Pokemon>();

        dbConnect dbConnect;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchInput, string typeFilter, int pg = 1)
        {
            // FromJson.getInstance();

            using (dbConnect = new dbConnect()) {
                abilities = dbConnect.abilities.ToList();
                if (searchInput != null)
                {
                    Poke = dbConnect.FromJson_Pokemon.Where(p => p.Name == searchInput).ToList();

                }
                if (typeFilter != null)
                {
                    Poke = dbConnect.FromJson_Pokemon.Where(p => p.types[0].Type.Name == typeFilter).ToList();

                }
                else
                {
                    Poke = dbConnect.FromJson_Pokemon.ToList();
                }
                ability = dbConnect.ability.ToList();
                sprites = dbConnect.Sprites.ToList();
                other = dbConnect.Other.ToList();
                homes = dbConnect.Home.ToList();
                Type = dbConnect.Type.ToList();
                types = dbConnect.types.ToList();

            }

                int pageSize = 12;
                if (pg < 1) pg = 1;

                int pocCount = Poke.Count + 1;
                var pager = new Page(pocCount, pg, pageSize);
                int recSkin = (pg - 1) * pageSize;
                var data = Poke.Skip(recSkin).Take(pager.PageSize).ToList();
                ViewBag.Pager = pager;
                return View(data);
            
        }

        public IActionResult TypeSelect( string typeFilter, int pg = 1)
        {

            using (dbConnect = new dbConnect())
            {
                abilities = dbConnect.abilities.ToList();

                
                ability = dbConnect.ability.ToList();
                sprites = dbConnect.Sprites.ToList();
                other = dbConnect.Other.ToList();
                homes = dbConnect.Home.ToList();
                Type = dbConnect.Type.ToList();
                types = dbConnect.types.ToList();

            }

            int pageSize = 12;
            if (pg < 1) pg = 1;

            int pocCount = Poke.Count + 1;
            var pager = new Page(pocCount, pg, pageSize);
            int recSkin = (pg - 1) * pageSize;
            var data = Poke.Skip(recSkin).Take(pager.PageSize).ToList();
            ViewBag.Pager = pager;
            return PartialView(data);
        }

        public IActionResult ClearView()
        {
            // Ваш код очищення view
            return PartialView(null);
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
