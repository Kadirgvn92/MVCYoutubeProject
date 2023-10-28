using Microsoft.AspNetCore.Mvc;
using MVCYoutubeProject.Data;
using MVCYoutubeProject.Models;

namespace MVCYoutubeProject.Controllers;
public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }
}
