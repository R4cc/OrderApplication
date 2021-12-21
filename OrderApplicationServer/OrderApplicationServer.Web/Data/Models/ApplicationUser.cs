using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OrderApplicationServer.Web.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(150)]
        public string FName { get; set; }
        [StringLength(150)]
        [Required]
        public string LName { get; set; } 
        public DateTime Birthdate { get; set; }
        public DateTime Created { get; set; }
    }
}
