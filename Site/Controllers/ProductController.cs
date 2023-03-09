using Microsoft.AspNetCore.Localization;
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
    public class ProductController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ProductController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetProducts(ProductParameters parameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            List<ProductModel> products = _unitOfWork.Product.GetProducts(parameters, otherLang).ToList();

            return Ok(products);
        }
        
    }
}