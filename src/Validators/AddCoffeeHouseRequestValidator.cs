using FluentValidation;
using HouseApi.Requests;

namespace HouseApi.Validators
{
    public class AddCoffeeHouseRequestValidator : AbstractValidator<AddCoffeeHouseRequest>
    {
        public AddCoffeeHouseRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.StreetAddress).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.State).NotEmpty();
            RuleFor(x => x.ZipCode).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
        }
    }
}