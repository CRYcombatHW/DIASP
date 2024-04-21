using DIASP.Abstract;
using DIASP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DIASP.Pages
{
    public class PersonModel : PageModel
    {
        private readonly IPersonOutputService _personOutputService;
        public Person Person { get; set; }

        public PersonModel(IPersonOutputService personOutputService) {
            _personOutputService = personOutputService;
        }

        public void OnGet()
        {
            Person = new Person() {
                Name = "test",
                Surname = "test",
                Age = 111,
            };

            _personOutputService.SaveToFile(Person, "person.txt");
        }
    }
}
