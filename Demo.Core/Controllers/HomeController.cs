using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo.Core.Models;

namespace Demo.Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Products()
        {
            ViewData["Message"] = "Your products page.";
            ViewBag.Message = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Products(string productName, 
            int productNumber, 
            decimal productCost, 
            string productDescription)
        {
            using (var context = new DemoDbContext())
            {
                var product = new Products
                {
                    Cost = productCost,
                    Description = productDescription,
                    Name = productName,
                    Number = productNumber
                };

                context.Products.Add(product);
                context.SaveChanges();
            }

            ViewBag.Message = "Successfully added product info to the database";
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
