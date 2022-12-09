using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using setsis_DAL.Concrete;
using setsis_EL.Concrete;
using System.Security.Claims;

namespace WebUI.Controllers
{
	//[Authorize]
	public class LoginController : Controller
	{
		Context c = new Context();

		[HttpGet]
		public IActionResult Index()//loginPage
		{
			return View();
		}
		[AllowAnonymous]
		public async Task<IActionResult> Login(User user)
		{
			var bilgiler = c.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
			if (bilgiler != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Email,user.Email)
				};
				var useridentity = new ClaimsIdentity(claims,"Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index","Login");	
			}
			return View();
		}

		
		public IActionResult LogOut()
		{
			//FormsAuthentication.SignOut();
			//Session.Abandon();
			return RedirectToAction();
		}
	}
}
