using LegateAirLine.Models;

namespace LegateAirLine.Services
{
    public interface ITripServices
    {
        Task<IEnumerable<TicketTrip>> GetAll();
        Task<TicketTrip> GetById(int id);
        Task<TicketTrip> Add(TicketTrip trip);
        TicketTrip Update(TicketTrip trip);
        TicketTrip Delete(TicketTrip trip);
    }
}
