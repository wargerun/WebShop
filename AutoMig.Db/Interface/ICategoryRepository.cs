using AutoMig.Entity;
using System.Linq;

namespace AutoMig.Interface
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAllCategories();
    }
}
