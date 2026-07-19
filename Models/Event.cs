using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace NOTESPACK.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 60 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Start date is required")]
        [Range(typeof(DateTime), "1900-01-01", "2100-01-01",
            ErrorMessage = "Start date must be after the year 1900")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "End date is required")]
        [EndDateAfterStartDate(nameof(Date))]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Duration is required")]
        public string Duration { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Organizer is required")]
        [StringLength(100, ErrorMessage = "Organizer cannot exceed 100 characters")]
        public string Organizer { get; set; } = string.Empty;

        public int? UserId { get; set; }
        public User User { get; set; } = null!;
    }

    // ============================================================
    // Custom Validation Attribute (EndDate must be after StartDate)
    // ============================================================
    public class EndDateAfterStartDate : ValidationAttribute
    {
        private readonly string _startDateProperty;

        public EndDateAfterStartDate(string startDateProperty)
        {
            _startDateProperty = startDateProperty;
            ErrorMessage = "End date must be after the start date";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var endDate = value as DateTime?;
            var startProp = validationContext.ObjectType.GetProperty(_startDateProperty);

            if (startProp == null)
                return new ValidationResult($"Unknown property {_startDateProperty}");

            var startDate = startProp.GetValue(validationContext.ObjectInstance) as DateTime?;

            if (startDate == null || endDate == null)
                return ValidationResult.Success;

            if (endDate <= startDate)
                return new ValidationResult(ErrorMessage);

            return ValidationResult.Success;
        }
    }
}
