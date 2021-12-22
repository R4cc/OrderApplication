using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OrderApplicationServer.Web.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(150, MinimumLength = 2)]
        public string FName { get; set; }
        [StringLength(150, MinimumLength = 2)]
        public string LName { get; set; } 
        public DateTime Birthdate { get; set; }
        public DateTime Created { get; set; }
    }
}
