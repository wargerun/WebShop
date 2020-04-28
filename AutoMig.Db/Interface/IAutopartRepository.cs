using AutoMig.Entity;
using System.Linq;

namespace AutoMig.Interface
{
    public interface IAutopartRepository
    {
        IQueryable<Autopart> GetAllAutoparts();

        Autopart GetAutopart(int autopartId);
    }
}
