using HouseApi.Models;
using MediatR;

namespace HouseApi.Requests
{
    public class AddCoffeeHouseRequest : IRequest<CoffeeHouse>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public short? Rating { get; set; }
    }
}