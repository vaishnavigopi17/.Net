using Microsoft.AspNetCore.Mvc;

namespace registration.Controllers
{
    public class registerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(register user)
        {
            if (ModelState.IsValid)
            {
                return Content($"Registration Successful\nName: {user.Name}\nEmail:{user.Email}\nAge:{user.Age}");

            }
            return View(user);
         }
     }

   
