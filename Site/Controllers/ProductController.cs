﻿using Contracts.Constants;
using CoreServices;
using Entities.CoreServicesModels.ProductModels;
using Microsoft.AspNetCore.Mvc;

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

            parameters.IgnoreNoneName = true;

            List<ProductModel> products = _unitOfWork.Product.GetProducts(parameters, otherLang).ToList();

            return Ok(products);
        }

    }
}