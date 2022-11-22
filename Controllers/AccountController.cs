using Microsoft.AspNetCore.Mvc;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register user)
        {
            using (var db = new AppDbContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
            
            return View();
        }

    }
}
