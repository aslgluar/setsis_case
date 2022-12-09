using Microsoft.AspNetCore.Mvc;
using setsis_BL.Concrete;
using setsis_DAL.Concrete;
using setsis_DAL.EntityFtamework;
using setsis_EL.Concrete;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Controllers
{
	public class CategoryController : Controller
	{
		CategoriyManager cm = new CategoriyManager(new EFCategoriyRepo());
		Context c = new Context();
		public IActionResult Index()
		{
			var values = cm.GetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCategory(Category category)
		{
			c.Add(category);
			c.SaveChanges();
			return View();
		}
		public IActionResult DeleteCategory(int id)
		{
			var cat = c.Categories.Find(id);
			c.Categories.Remove(cat);
			c.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult EditCategory(int id)
		{
			var cat = c.Categories.Find(id);
			return View("EditCategory",cat);
		}

		public IActionResult UpdateCategory(Category category)
		{
			var cat = c.Categories.Find(category.CategoryID);
			cat.CategoryName = category.CategoryName;
			cat.CategoryStatus = category.CategoryStatus;
			cat.CategoryDescription = category.CategoryDescription;
			c.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
