using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApp14.Pages
{
    public class DataBindingModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; } = new Person();

        public static List<Person> People { get; } = new List<Person>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                People.Add(new Person
                {
                    Id = Person.Id,
                    Name = Person.Name,
                    Age = Person.Age
                });
            }
            return Page();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
