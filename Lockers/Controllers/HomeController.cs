using Lockers.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lockers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DateTime _expire;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _expire = new DateTime(2023, 01, 30);
        }

        public IActionResult Index()
        {
            if (_expire < DateTime.Now.Date)
            {
                return NotFound();
            }

            ViewBag.Active = "Home";

            return View();
        }

        public IActionResult About()
        {
            if (_expire < DateTime.Now.Date)
            {
                return NotFound();
            }

            ViewBag.Active = "About";

            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {

            return Ok();
        }

        [Route("{culture}")]
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