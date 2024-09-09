using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Users
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }

        // Navigation property for adoptions
        public ICollection<Adoptions> Adoptions { get; set; } = new List<Adoptions>();
    }
}
