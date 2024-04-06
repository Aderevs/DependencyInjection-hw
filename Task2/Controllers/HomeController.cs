using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalcService _calcService;

        public HomeController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int x, int y)
        {
            var result = _calcService.Add(x, y);
            return View("Index", result);
        }
        public IActionResult Sub(double x, double y)
        {
            var result = _calcService.Sub(x, y);
            return View("Index", result);
        }
        public IActionResult Mul(double x, double y)
        {
            var result = _calcService.Mul(x, y);
            return View("Index", result);
        }
        public IActionResult Div(double x, double y)
        {
            var result = _calcService.Div(x, y);
            return View("Index", result);
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
