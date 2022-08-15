using System.ComponentModel.DataAnnotations.Schema;

namespace LegateAirLine.Models
{
    public class Bag
    {
        public int BagId { get; set; }
        public int BagWeight { get; set; }
        public int NumberBags { get; set; }
        public string Contents { get; set; }
        public int TravelerId { get; set; }

        public Traveler Traveler { get; set; }
        
    }
}
