using System;
using System.ComponentModel.DataAnnotations;

namespace lab_10.Validators
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var selectedDate = (DateTime)value;

            if (selectedDate.Date <= DateTime.Now.Date)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
