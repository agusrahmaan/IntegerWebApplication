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
                Gender = "Laki-laki",
                Address = "Ciamis",
                PhoneNumber = "081224712129"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Toyyib",
                Gender = "Laki-laki",
                Address = "Banyumas",
                PhoneNumber = "088190025142"
            });

            student.Add(new Student()
            {
                Id = 3,
                Name = "Andriansyah",
                Gender = "Laki-laki",
                Address = "Cirebon",
                PhoneNumber = "085699395114"
            });

            student.Add(new Student()
            {
                Id = 4,
                Name = "Fauzi",
                Gender = "Laki-laki",
                Address = "Cianjur",
                PhoneNumber = "081267443001"
            });

            student.Add(new Student()
            {
                Id = 5,
                Name = "Suci",
                Gender = "Perempuan",
                Address = "Banjar",
                PhoneNumber = "081866410923"
            });

            student.Add(new Student()
            {
                Id = 6,
                Name = "Sawal",
                Gender = "Laki-laki",
                Address = "Padang Sidimpuan",
                PhoneNumber = "088132555622"
            });

            student.Add(new Student()
            {
                Id = 7,
                Name = "Dede Adam",
                Gender = "Laki-laki",
                Address = "Banjar",
                PhoneNumber = "081534412027"
            });

            student.Add(new Student()
            {
                Id = 8,
                Name = "Naily",
                Gender = "Perempuan",
                Address = "Banyumas",
                PhoneNumber = "085538309971"
            });

            student.Add(new Student()
            {
                Id = 9,
                Name = "Helmi",
                Gender = "Laki-laki",
                Address = "Banjar",
                PhoneNumber = "087439003121"
            });

            student.Add(new Student()
            {
                Id = 10,
                Name = "Melani",
                Gender = "Perempuan",
                Address = "Banjar",
                PhoneNumber = "081200726762"
            });
            return View(student);
        }
    }
}
