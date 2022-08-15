using AutoMapper;
using LegateAirLine.Dto;
using LegateAirLine.Models;
using LegateAirLine.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LegateAirLine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TravelersController : ControllerBase
    {
        private readonly ITravelerServices _travelerServices;
        public TravelersController(ITravelerServices travelerServices  )
        {
            _travelerServices = travelerServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTravelers()
        {
            var travelers = await _travelerServices.GetAll();
            return Ok(travelers);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewTraveler(TravelerDto travelerDto)
        {
            var traveler = new Traveler
            {
                FirstName = travelerDto.FirstName,
                LastName = travelerDto.LastName,
                Countery = travelerDto.Countery,
                Age = travelerDto.Age,
                Job = travelerDto.Job
            };
            await _travelerServices.Add(traveler);
            return Ok(traveler);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTraveler(int id, TravelerDto travelerDto)
        {
            var traveler = await _travelerServices.GetById(id);
            if (traveler == null)
                return NotFound("This traveler is not restricted");
            traveler.FirstName = travelerDto.FirstName;
            traveler.LastName = travelerDto.LastName;
            traveler.Countery = travelerDto.Countery;
            traveler.Age = travelerDto.Age;
            traveler.Job = travelerDto.Job;
            _travelerServices.Update(traveler);
            return Ok(traveler);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteTraveler(int id ,TravelerDto travelerDto)
        {
            var traveler= await _travelerServices.GetById(id);
            if (traveler == null)
                return NotFound("This traveler is not restricted");
            _travelerServices.Delete(traveler);
            return Ok(traveler);


        }

    }
}
