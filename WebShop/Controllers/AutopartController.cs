using AutoMig.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebShop.Controllers
{
    public class AutopartController : Controller
    {
        private readonly IAutopartRepository _autopartRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AutopartController(IAutopartRepository autopartRepository, ICategoryRepository categoryRepository)
        {
            _autopartRepository = autopartRepository;
            _categoryRepository = categoryRepository;
        }
        
        public ViewResult Index()
        {
            ViewBag.Title = "Список запчастей";

            IEnumerable<AutoMig.Entity.Autopart> Autoparts = _autopartRepository.GetAllAutoparts().ToList();
            return base.View(Autoparts);
        }
    }
}