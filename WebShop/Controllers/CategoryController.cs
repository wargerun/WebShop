using AutoMig;
using AutoMig.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Categories";

            var categories = _categoryRepository.GetAllCategories().ToList();
            var image = ImageHelper.GetBytesFromImage(@"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.png");

            categories.ForEach(c => c.Image = image);

            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Title = "Categories";

            var categories = _categoryRepository.GetAllCategories().ToList();
            var image = ImageHelper.GetBytesFromImage(@"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.png");

            categories.ForEach(c => c.Image = image);

            return View(categories);
        }
    }
}