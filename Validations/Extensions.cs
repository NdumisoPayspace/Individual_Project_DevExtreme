using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Individual_Project_DevExtreme.Validations
{
    public static class Extensions
    {
        public static void AddToModelState(ValidationResult validationResult, ModelStateDictionary modelState)
        {
            foreach(var error in validationResult.Errors)
            {
                modelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
    }
}
