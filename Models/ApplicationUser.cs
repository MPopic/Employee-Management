using Microsoft.AspNetCore.Identity;

namespace Employee_Management.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
