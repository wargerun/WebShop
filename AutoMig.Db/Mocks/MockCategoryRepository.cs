using AutoMig.Entity;
using AutoMig.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AutoMig.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public const string NOISE_INSULATION = "Шумоизоляция";
        public const string SUSPENSION = "Подвеска";

        public IQueryable<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category { Name = "Шины", Description = "Описание Шин !"},
                new Category { Name = "Трансмиссионные масла", Description = "Описание подвески !"},
                new Category { Name = "Аккумуляторы", Description = "Описание подвески !"},
                new Category { Name = "Запчасти для техобслуживания", Description = "Описание подвески !"},
                new Category { Name = "Диски", Description = "Описание подвески !"},
                new Category { Name = "Защита картера", Description = "Описание подвески !"},
                new Category { Name = "Автомобильные стекла", Description = "Описание подвески !"},
                new Category { Name = "Моторные масла", Description = "Описание подвески !"},
            };

            var enumerable = categories.Concat(categories).ToList();
            enumerable.RemoveAt(0);
            return enumerable.OrderBy(c => c.Name).AsQueryable();
        }
    }
}
