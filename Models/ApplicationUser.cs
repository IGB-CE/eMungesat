using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eMungesat.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Id {  get; set; }
        public string FullName { get; set; }
        public string? Address { get; set; }
    }

}
