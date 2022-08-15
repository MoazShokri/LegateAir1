using System.ComponentModel.DataAnnotations;

namespace LegateAirLine.Models
{
    public class Traveler
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Countery { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Job { get; set; }
        public List<Bag> Bags { get; set; }
      

    }
}
