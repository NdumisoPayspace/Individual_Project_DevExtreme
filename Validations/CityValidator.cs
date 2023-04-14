namespace Individual_Project_DevExtreme.Validations
{
    using FluentValidation;
    using Individual_Project_DevExtreme.Models;

    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            this.RuleFor(_ => _.CityName)
                .NotEmpty()
                .MaximumLength(85);
        }
    }
}
