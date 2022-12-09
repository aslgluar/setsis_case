using Microsoft.AspNetCore.Mvc;
using setsis_DAL.Concrete;
using setsis_EL.Concrete;

namespace WebUI.Controllers
{
    public class RegisterController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Register(User user)
        {
            await c.Users.AddAsync(user);
            await c.SaveChangesAsync();
            return Redirect("Register");
        }
    }
}
