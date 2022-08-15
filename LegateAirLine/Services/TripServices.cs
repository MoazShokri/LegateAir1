using LegateAirLine.Models;
using Microsoft.EntityFrameworkCore;

namespace LegateAirLine.Services
{
    public class TripServices:ITripServices
    {
        private readonly ApplicationDbcontext _context;
        public TripServices(ApplicationDbcontext context)
        {
            _context = context; 

        }
        public async Task<IEnumerable<TicketTrip>>GetAll()
        {
            return await _context.Trips.Include(m=>m.Traveler).ToListAsync();
        }
        public async Task<TicketTrip>GetById (int id)
        {
            return await _context.Trips.Include(m => m.Traveler).SingleOrDefaultAsync(t => t.Id == id);
        }
        public async Task<TicketTrip>Add(TicketTrip trip)
        {
            await _context.Trips.AddAsync(trip);
            _context.SaveChanges();
            return trip; 
        }
        public TicketTrip Update (TicketTrip trip)
        {
            _context.Update(trip);
            _context.SaveChanges();
            return trip;
        }
        public TicketTrip Delete (TicketTrip trip)
        {
            _context.Remove(trip);
            _context.SaveChanges();
            return (trip);
        }
      
    }
}
