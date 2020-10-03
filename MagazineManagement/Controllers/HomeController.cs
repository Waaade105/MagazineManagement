using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MagazineManagement.Models;
using MagazineManagement.ViewModels;

namespace MagazineManagement.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult ProductDetails(int id)
        {
            HomeProdDetailsViewModel homeProdDetailsViewModel = new HomeProdDetailsViewModel()
            {
                Product = _productRepository.GetProduct(id),
                Title = "Product details",
            };
            //Product product = _productRepository.GetProduct(id);
            //return View(product);
            return View(homeProdDetailsViewModel);
        }



        public IActionResult Index()
        {
            //return _productRepository.GetProduct(1).Name;
            var model = _productRepository.GetAllPRoducts();
            return View(model);
        }

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    Product product = _productRepository.GetProduct(id);
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Details()
        //{
        //    return View();
        //}

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
