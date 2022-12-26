using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();

            student.Add(new Student()
            {
                Id = 1,
                Name = "Agus",
                Address = "Ciamis",
                PhoneNumber = "1234567890"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Toyyib",
                Address = "Banyumas",
                PhoneNumber = "1234567890"
            });

            return View(student);
        }
    }
}
