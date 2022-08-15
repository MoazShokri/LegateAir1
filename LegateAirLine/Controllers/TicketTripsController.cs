using LegateAirLine.Dto;
using LegateAirLine.Models;
using LegateAirLine.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegateAirLine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTripsController : ControllerBase
    {
        private readonly ITripServices _tripServices;
        public TicketTripsController(ITripServices tripServices)
        {
            _tripServices = tripServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var trips = await _tripServices.GetAll();
            return Ok(trips);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var trips = await _tripServices.GetById(id);
            if(trips == null)
                return NotFound("this trip id does not exist");
            return Ok(trips);
        }
        [HttpPost]
        public async Task<IActionResult>CreateTrip(TripDto tripDto)
        {
            var trip = new TicketTrip
            {
                FlightDate = tripDto.FlightDate,
                FlightName = tripDto.FlightName,
                FlightTime = tripDto.FlightTime,
                Arrival = tripDto.Arrival,
                TravelerId = tripDto.TravelerId,
            };
            await _tripServices.Add(trip);
            return Ok(trip);
        }
        [HttpPut("{id}")]
        public async Task <IActionResult>UpdateTrip(int id ,[FromBody]TripDto tripDto )
        {
            var trip = await _tripServices.GetById(id);
            if(trip == null)
                return NotFound("this trip id does not exist");
            trip.FlightDate = tripDto.FlightDate;
            trip.FlightName = tripDto.FlightName;
            trip.FlightTime = tripDto.FlightTime;
            trip.Arrival = tripDto.Arrival;
            trip.TravelerId = tripDto.TravelerId;
            _tripServices.Update(trip);
            return Ok(trip);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteTrip(int id)
        {
            var trip =await _tripServices.GetById(id);
            if (trip == null)
                return NotFound("this trip id does not exist");
            _tripServices.Delete(trip);
            return Ok("This Trip Canceled");

        }
        


    }
}
