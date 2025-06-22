using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorSSRApp.Models
{
    public class Server : IValidatableObject
    {
        public bool IsOnline { get; set; }
        public int PeopleOnline { get; set; }

        [Required(ErrorMessage = "Server name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;

        // catch whitespace-only entries
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Name))
                yield return new ValidationResult(
                    "Server name cannot be blank or whitespace",
                    new[] { nameof(Name) });

            if (string.IsNullOrWhiteSpace(City))
                yield return new ValidationResult(
                    "Please select a city",
                    new[] { nameof(City) });
        }
    }
}
