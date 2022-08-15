using LegateAirLine.Models;

namespace LegateAirLine.Services
{
    public interface ITravelerServices
    {
        Task<IEnumerable<Traveler>> GetAll();
        Task<Traveler> Add(Traveler traveler);
        Task<Traveler> GetById(int id);
        Traveler Update(Traveler traveler);
        Traveler Delete(Traveler traveler);

    }
}
