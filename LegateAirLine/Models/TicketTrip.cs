using System.ComponentModel.DataAnnotations.Schema;

namespace LegateAirLine.Models
{
    public class TicketTrip
    {
        public int Id { get; set; }
        public string FlightName { get; set; }
        public string FlightDate { get; set; }
        public string FlightTime { get; set; }
         public string Arrival { get; set; }
        public int TravelerId { get; set; }
        public Traveler Traveler { get; set; }



    }
}
