using Microsoft.AspNetCore.Identity;

namespace eMungesat.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }

}
