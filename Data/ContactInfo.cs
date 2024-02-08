using System.ComponentModel.DataAnnotations;

namespace BlazorInputValidatione.Data
{
    public class ContactInfo
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; } = "";
    }
}