using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HouseApi.Models;
using HouseApi.Requests;
using System.Collections.Generic;

namespace HouseApi.Controllers
{
    [Authorize]
    public class HouseController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> AddCoffeeHouse(AddCoffeeHouseRequest request)
        {
            var coffeeHouse = await Mediator.Send(request);
            return CreatedAtAction(nameof(GetCoffeeHouses), new { id = coffeeHouse.Id }, coffeeHouse);
        }

        [HttpGet]
        public async Task<List<CoffeeHouse>> GetCoffeeHouses()
        {
            return await Mediator.Send(new GetCoffeeHousesRequest());
        }
    }
}