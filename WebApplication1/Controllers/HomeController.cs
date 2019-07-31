using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebsiteForTrueCoders;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller //inheriting from class controller where View is a method in that class. it is set up by using microsoft.aspnetcore.mvc
    {
        public IActionResult Index()
        {
            ProductRepository repo = new ProductRepository();
            List<Product> allProducts = repo.GetAllProducts();

            return View(allProducts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
