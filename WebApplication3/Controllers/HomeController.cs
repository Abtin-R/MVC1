using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Games()
        {
            VideoGameRepository v = new VideoGameRepository();
            return View(v);
        }

        public IActionResult GameDetails(string id)
        {
            VideoGameRepository v = new VideoGameRepository();
            VideoGame ga = v.VideoGames.FirstOrDefault(i => i.Title.ToLower() == id.ToLower());

            return View(ga);
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