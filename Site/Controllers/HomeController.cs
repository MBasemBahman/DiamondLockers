﻿using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Contracts.Constants;
using CoreServices;
using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Org.BouncyCastle.Ocsp;
using Site.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly DateTime _expire;

        public HomeController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _expire = new DateTime(2023, 01, 30);
        }

        public IActionResult Index()
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];
            
            ViewData["Category"] = _unitOfWork.MainData.GetCategoriesLookUp(new CategoryParameters(), otherLang);
            ViewData["Size"] = _unitOfWork.MainData.GetSizesLookUp(new SizeParameters(), otherLang);
            ViewData["Color"] = _unitOfWork.MainData.GetColorsLookUp(new ColorParameters(), otherLang);
            
            ViewData["Product"] = _unitOfWork.Product.GetProducts(new ProductParameters(), otherLang);

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