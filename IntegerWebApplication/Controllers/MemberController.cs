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

            member.Add(new Member()
            {
                MemberId = 4,
                Name = "Ahmad Faisal Hidayat",
                Division = "Core Manager",
                Position = "Chairman"
            });

            member.Add(new Member()
            {
                MemberId = 5,
                Name = "Ali Hanafiah",
                Division = "Cleaning Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 6,
                Name = "Aliya Rohaya Siregar",
                Division = "Education Division",
                Position = "Treasurer"
            });

            member.Add(new Member()
            {
                MemberId = 7,
                Name = "Amelia Siregar",
                Division = "Core Manager",
                Position = "Security"
            });

            member.Add(new Member()
            {
                MemberId = 8,
                Name = "Ananda Pratama Indra Buana",
                Division = "Cleaning Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 9,
                Name = "Andriansyah",
                Division = "Cleaning Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 10,
                Name = "Anggi Permana",
                Division = "Core Manager",
                Position = "Security"
            });

            member.Add(new Member()
            {
                MemberId = 11,
                Name = "Annur Akbar Bahagia",
                Division = "Hostel Division",
                Position = "Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 12,
                Name = "Arya Kusuma Agniqoyad",
                Division = "Spiritual Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 13,
                Name = "Avita Diah Saputri",
                Division = "Hostel Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 14,
                Name = "Azhari Fahreza Lubis",
                Division = "Welfare Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 15,
                Name = "Bagas Rizky Herdiansyah Putra",
                Division = "Admissions Committee",
                Position = "Documentation"
            });

            member.Add(new Member()
            {
                MemberId = 16,
                Name = "Bunga Sari Hutasuhut",
                Division = "Welfare Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 17,
                Name = "Dede Adam Alamsyah",
                Division = "Spiritual Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 18,
                Name = "Dimas Firmansyah",
                Division = "Education Division",
                Position = "Secretary"
            });

            member.Add(new Member()
            {
                MemberId = 19,
                Name = "Dwi Fauzul Ahmad Tanjung",
                Division = "Health Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 20,
                Name = "Farhan Ramadhan Muchtar",
                Division = "Core Manager",
                Position = "Security"
            });

            member.Add(new Member()
            {
                MemberId = 21,
                Name = "Helmi Tris Edyan",
                Division = "Cleaning Division",
                Position = "Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 22,
                Name = "Kharisma Amalia",
                Division = "Core Manager",
                Position = "Internal Treasures"
            });

            member.Add(new Member()
            {
                MemberId = 23,
                Name = "Krise Rohalia",
                Division = "Spiritual Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 24,
                Name = "Kurniawan",
                Division = "Health Manager",
                Position = "Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 25,
                Name = "M Azriel Pazarudin",
                Division = "Education Division",
                Position = "Public Relations"
            });

            member.Add(new Member()
            {
                MemberId = 26,
                Name = "Maulina Inas Nasya",
                Division = "Spiritual Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 27,
                Name = "Maypa Dea Fazrin",
                Division = "Hostel Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 28,
                Name = "Melani Putri",
                Division = "Welfare Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 29,
                Name = "Muhammad Fadli Fathurrahman",
                Division = "Education Division",
                Position = "Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 30,
                Name = "Naily Rina Pribawa",
                Division = "Education Division",
                Position = "Deputy Coordinator"
            });

            member.Add(new Member()
            {
                MemberId = 31,
                Name = "Peni Julianti",
                Division = "Core Manager",
                Position = "Secretary"
            });

            member.Add(new Member()
            {
                MemberId = 32,
                Name = "Putri Lestari",
                Division = "Core Manager",
                Position = "External Treasures"
            });

            member.Add(new Member()
            {
                MemberId = 33,
                Name = "Putri Mulyani",
                Division = "Health Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 34,
                Name = "Riyanda Ramadhan",
                Division = "Hostel Manager",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 35,
                Name = "Sawaluddin",
                Division = "Education Division",
                Position = "Public Relations"
            });

            member.Add(new Member()
            {
                MemberId = 36,
                Name = "Suci Amanah",
                Division = "Hostel Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 37,
                Name = "Tigana Reymansyah",
                Division = "Edaucation Division",
                Position = "Public Relations"
            });

            member.Add(new Member()
            {
                MemberId = 38,
                Name = "Toyyib Hendrasto",
                Division = "Welfare Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 39,
                Name = "Tri Wulandari",
                Division = "Health Division",
                Position = "Member"
            });

            member.Add(new Member()
            {
                MemberId = 40,
                Name = "Wahyu",
                Division = "Admissions Committee",
                Position = "Chairman"
            });
            return View(member);
        }
    }
}
