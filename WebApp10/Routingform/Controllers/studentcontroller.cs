using Microsoft.AspNetCore.Mvc;

namespace ActionResult.Controllers

{
    [Route("Student")]
    public class studentcontroller : Controller
    {
        [Route("Input/{id}")]
        public IActionResult Input(int id,string name)
        {
            string message = $"Student id:{id},student name: {name}";
            return Content(message);
        }
        [Route("Marks/{id}/{subject}")]

        public IActionResult Marks(int id, string subject)
        {
            return Content("Student ID is: " + id + " Subject is: " + subject);
        }
    }
}
