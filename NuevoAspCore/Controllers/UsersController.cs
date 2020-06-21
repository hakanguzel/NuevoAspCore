using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NuevoAspCore.Models;
using NuevoAspCore.Models.DbModels;

namespace NuevoAspCore.Controllers
{
    public class UsersController : Controller
    {
        private readonly NuevoContext _context;

        public UsersController(NuevoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Users loginModel)
        {
            var user = LoginUser(loginModel.Username, loginModel.Password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("/WebSites/Index");
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }

        private Users LoginUser(string username, string password)
        {
            var users = _context.Users.FirstOrDefault(m => m.Username == username && m.Password == password);


            if (users != null)
            {
                return users;
            }

            return null;

        }
    }
}
