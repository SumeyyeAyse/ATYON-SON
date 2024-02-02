using Atyon.DTO;
using FluentValidation;

namespace Atyon.Validators
{
    public class FacilityValidator : AbstractValidator<Facility>
    {
        public FacilityValidator()
        {
            RuleFor(a => a.FacilityName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(a => a.WasteStockCode)
                .NotEmpty()
                .WithMessage("'Waste Stock Kod' must not be 0.");
        }
    }
}
