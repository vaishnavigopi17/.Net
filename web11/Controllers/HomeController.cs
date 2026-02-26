using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;
using WebApplication11.Service;


namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyservice _service;

        public HomeController(IMyservice service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);
        }
    }
}
