using Microsoft.AspNetCore.Mvc;
using razor.Models;

namespace razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<product> products = new List<product>
            {
                new product { Id = 1,Name="Laptop", Price=55000 },
                new product { Id = 2, Name = "Mobile", Price = 25000 },
                new product { Id = 3, Name = "Headphones", Price = 3000 },
                new product { Id =4, Name="Earphone", Price= 2000},
                new product {Id=5, Name="Tab", Price=4000}
            };
            return View(products);
        }
    }
}

