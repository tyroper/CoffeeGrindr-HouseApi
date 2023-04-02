using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HouseApi.DataAccess;
using HouseApi.Models;
using HouseApi.Requests;
using MediatR;

namespace HouseApi.Handlers
{
    public class GetCoffeeHousesHandler : IRequestHandler<GetCoffeeHousesRequest, List<CoffeeHouse>>
    {
        private readonly MongoDbService _service;
        public GetCoffeeHousesHandler(MongoDbService service)
        {
            _service = service;
        }
        public async Task<List<CoffeeHouse>> Handle(GetCoffeeHousesRequest request, CancellationToken cancellationToken)
        {
            return await _service.GetAsync();
        }
    }
}