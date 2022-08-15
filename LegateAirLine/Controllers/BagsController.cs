using LegateAirLine.Dtos;
using LegateAirLine.Models;
using LegateAirLine.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegateAirLine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BagsController : ControllerBase
    {
        private readonly IBagServices _bagServices;
        public BagsController(IBagServices bagServices)
        {
            _bagServices = bagServices;
        }
        [HttpGet]
        public async Task<IActionResult>GetAll ()
        {
            var bags = await _bagServices.GetAll ();
            return Ok(bags) ;
        }
        [HttpPost]
        public async Task<IActionResult>AddBag (BagDto bagDto)
        {
            if (bagDto.BagWeight == null)
                return BadRequest("BagWeight is required");
            if (bagDto.BagWeight > 100)
                return BadRequest("Max allow weight is 100kg");
            var bags = new Bag
            {
                NumberBags = bagDto.NumberBags,
                BagWeight = bagDto.BagWeight,
                Contents = bagDto.Contents,
                TravelerId = bagDto.TravelerId,

            };
            await _bagServices.Add(bags);
            return Ok(bags);
        }
    }
}
