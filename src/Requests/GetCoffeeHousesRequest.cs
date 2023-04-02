using System.Collections.Generic;
using HouseApi.Models;
using MediatR;

namespace HouseApi.Requests
{
    public class GetCoffeeHousesRequest : IRequest<List<CoffeeHouse>>
    {
    }
}