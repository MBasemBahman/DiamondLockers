using Lockers.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lockers.Controllers
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
            ViewBag.Active = "Home";

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Active = "About";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {

            return Ok();
        }

        [Route(nameof(Culture))]
        public IActionResult Culture(string culture)
        {
            if (string.IsNullOrWhiteSpace(culture))
            {
                culture = "ar";
            }

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture: "en", uiCulture: culture)));

            return Request.Headers["Referer"].Any() ? Redirect(Request.Headers["Referer"].ToString()) : RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}