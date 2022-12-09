using Microsoft.AspNetCore.Mvc;
using setsis_BL.Concrete;
using setsis_DAL.EntityFtamework;

namespace setsis_case_PL.Controllers
{
    public class CategoryController : Controller
    {
        CategoriyManager categoriyManager = new CategoriyManager(new EFCategoriyRepo());
        public IActionResult Index()
        {
            var values = categoriyManager.GetAll();
            return View();
        }
    }
}
