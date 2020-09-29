using System.ComponentModel.DataAnnotations;

namespace Employee_Management.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
