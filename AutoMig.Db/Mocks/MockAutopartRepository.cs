using AutoMig.Entity;
using AutoMig.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AutoMig.Mocks
{
    public class MockAutopartRepository : IAutopartRepository
    {
        private static readonly IQueryable<Category> allCategory = new MockCategoryRepository().GetAllCategories();

        public IQueryable<Autopart> GetAllAutoparts()
        {
            return new List<Autopart> {
                // Подвестки
                new Autopart {
                    Name = "Амортизатор передний Логан, Ларгус Gallant",
                    Brand = "Gallant",
                    Model = "GL.SA.1.4",
                    Available = 4,
                    Country = "Germany",
                    Photo = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg",
                    Price = 1508.7M,
                    Discription = "-",
                    Category = allCategory.FirstOrDefault(c => c.Name == MockCategoryRepository.SUSPENSION)
                }, new Autopart {
                    Name = "АМОРТИЗАТОР ЗАДНИЙ ЛОГАН, ЛАРГУС GALLANT",
                    Brand = "Gallant",
                    Model = "GL.SA.1.5",
                    Available = 2,
                    Country = "Germany",
                    Photo = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg",
                    Price = 1189.04M,
                    Discription = "-",
                    Category = allCategory.FirstOrDefault(c => c.Name == MockCategoryRepository.SUSPENSION)
                }, new Autopart {
                    Name = "СТОЙКА АМОРТИЗАТОРА ПЕРЕДНЯЯ (ЛЕВАЯ+ПРАВАЯ) 1118 TY",
                    Brand = "Gallant",
                    Model = "GL.SA.1.38",
                    Available = 0,
                    Country = "Germany",
                    Photo = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg",
                    Price = 3318.34M,
                    Discription = "-",
                    Category = allCategory.FirstOrDefault(c => c.Name == MockCategoryRepository.SUSPENSION)
                },
                // Шумоизоляция 
                new Autopart {
                    Name = "1118-5007118Р БРТ",
                    Brand = "БРТ",
                    Model = "1118-5007118Р",
                    Available = 21,
                    Country = "Россия",
                    Photo = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg",
                    Price = 396.73M,
                    Discription = "-",
                    Category = allCategory.FirstOrDefault(c => c.Name == MockCategoryRepository.NOISE_INSULATION)
                },
                new Autopart {
                    Name = "НАСОС СТЕКЛООМЫВАТЕЛ( 1СОСОК) 6001549444 RENAULT (LOGAN), LADA (LARGUS) ФУРГОН",
                    Brand = "Renault",
                    Model = "6001549443",
                    Available = 21,
                    Country = "Россия",
                    Photo = @"D:\Repository\Web\WebShop\WebShop\wwwroot\Img\no-image.jpg",
                    Price = 312.5M,
                    Discription = "-",
                    Category = allCategory.FirstOrDefault(c => c.Name == MockCategoryRepository.NOISE_INSULATION)
                }
            }.AsQueryable();
        }

        public Autopart GetAutopart(int autopartId)
        {
            return GetAllAutoparts().SingleOrDefault(a => a.Id == autopartId);
        }
    }
}
