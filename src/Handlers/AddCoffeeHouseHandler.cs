using System;
using System.Threading;
using System.Threading.Tasks;
using HouseApi.DataAccess;
using HouseApi.Models;
using HouseApi.Requests;
using MediatR;

namespace HouseApi.Handlers
{
    public class AddCoffeeHouseHandler : IRequestHandler<AddCoffeeHouseRequest, CoffeeHouse>
    {
        private readonly MongoDbService _service;
        public AddCoffeeHouseHandler(MongoDbService service)
        {
            _service = service;
        }

        public async Task<CoffeeHouse> Handle(AddCoffeeHouseRequest request, CancellationToken cancellationToken)
        {
            var coffeeHouse = new CoffeeHouse
            {
                Name = request.Name,
                Description = request.Description,
                StreetAddress = request.StreetAddress,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Rating = request.Rating
            };

            await _service.CreateAsync(coffeeHouse);

            return coffeeHouse;
        }
    }
}