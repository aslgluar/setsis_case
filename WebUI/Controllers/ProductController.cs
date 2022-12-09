using Microsoft.AspNetCore.Mvc;
using setsis_BL.Concrete;
using setsis_DAL.EntityFtamework;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductRepo());
        public IActionResult Index()
        {
            var values = pm.GetAll();
            return View(values);
        }
        public IActionResult GetCategory(int id)
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }
    }
}
