using LegateAirLine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LegateAirLine.Services
{
    public class TravelerServices :ITravelerServices
    {
        private readonly ApplicationDbcontext _context;
        public TravelerServices(ApplicationDbcontext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Traveler>>GetAll()
        {
            return await _context.Travelers.ToListAsync();
        }
        public async Task<Traveler>Add(Traveler traveler)
        {
           await _context.AddAsync(traveler);
            _context.SaveChanges();
            return traveler;
        }
        public async Task<Traveler>GetById(int id)
        {
            return await _context.Travelers.SingleOrDefaultAsync(T => T.Id==id);
        }
        public Traveler Update(Traveler traveler)
        {
            _context.Update(traveler);
            _context.SaveChanges();
            return traveler;
        }
        public Traveler Delete (Traveler traveler)
        {
            _context.Remove(traveler);
            _context.SaveChanges();
            return(traveler);

        }
       
    }
}
