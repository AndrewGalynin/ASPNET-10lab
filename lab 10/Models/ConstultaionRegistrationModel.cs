using lab_10.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace lab_10.Models
{
    public class ConsultationRegistrationModel : NotWeekendAttribute
    {
        [Required(ErrorMessage = "Поле Ім'я прізвище є обов'язковим")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Email є обов'язковим")]
        [EmailAddress(ErrorMessage = "Введіть правильний формат Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Бажана дата консультації є обов'язковим")]
        [DataType(DataType.Date, ErrorMessage = "Введіть правильний формат дати")]
        [NotWeekend(ErrorMessage = "Консультації не проводяться вихідними")]
        public DateTime ConsultationDate { get; set; }

        [Required(ErrorMessage = "Виберіть продукт для консультації")]
        public string SelectedProduct { get; set; }
    }

}
