using LegateAirLine.Models;

namespace LegateAirLine.Services
{
    public interface IBagServices
    {
        Task<IEnumerable<Bag>> GetAll();
        Task<Bag> Add(Bag bag);
    }
}
