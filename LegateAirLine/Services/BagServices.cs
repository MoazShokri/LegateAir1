using LegateAirLine.Models;
using Microsoft.EntityFrameworkCore;

namespace LegateAirLine.Services
{
    public class BagServices : IBagServices
    {
        private readonly ApplicationDbcontext _context;
        public BagServices(ApplicationDbcontext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Bag>> GetAll()
        {
            return await _context.Bags.Include(t => t.Traveler).ToListAsync();
        }
        public async Task<Bag> Add(Bag bag)
        {
            await _context.Bags.AddAsync(bag);
            _context.SaveChanges();
            return bag;
        }
    }
}
