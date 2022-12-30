using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var member = new List<Member>();

            member.Add(new Member()
            {
                MemberId = 1,
                Name = "Achmad Farhan Fauzan",
                Division = "Education Division",
                Position = "Secretary"
            });

            member.Add(new Member()
            {
                MemberId = 2,
                Name = "Achmad Fauzi Suhandi",
                Division = "Welfare Division",
                Position = "Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 3,
                Name = "Agus Rahman Hidayat",
                Division = "Spiritual Division",
                Position = "Coordinator"
            });
            return View(member);
        }
    }
}
