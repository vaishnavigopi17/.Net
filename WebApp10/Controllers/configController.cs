using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class configController : Controller
    {
        private readonly IConfiguration _configuration;
        public configController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.AppName = _configuration["AppSettings:ApplicationName"];
            ViewBag.Version = _configuration["AppSettings:Version"];
            ViewBag.Developer= _configuration["AppSettings:Developer"];
            return View();
        }
    }
}
