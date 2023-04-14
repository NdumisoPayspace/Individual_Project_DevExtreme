namespace Individual_Project_DevExtreme.Controllers
{
    using FluentValidation;
    using FluentValidation.AspNetCore;
    using Individual_Project_DevExtreme.Models;
    using Microsoft.AspNetCore.Mvc;

    public class WeatherController : Controller
    {
        private readonly IValidator<City> cityValidator;

        public WeatherController(IValidator<City> cityValidator)
        {
            this.cityValidator = cityValidator;
        }

        public IActionResult Index(City? model)
        {
            var result = cityValidator.Validate(model);

            if(!result.IsValid)
            {
                result.AddToModelState(ModelState);
                return View();
            }

            ViewBag.city = model.CityName;
            return View();
        }
    }
}
