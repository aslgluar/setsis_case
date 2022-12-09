using Microsoft.AspNetCore.Mvc;
using setsis_BL.Concrete;
using setsis_DAL.EntityFtamework;

namespace Core_Demo.Controllers
{
    public class CategoryController : Controller
    {
        CategoriyManager cm = new CategoriyManager(new EFCategoriyRepo());
        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }
    }
}
