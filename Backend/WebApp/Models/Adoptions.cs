using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Adoptions
    {
        [Key]
        public string AdoptionId { get; set; }
        public DateTime AdoptionDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "pending";

        // Foreign Keys
        public string UserId { get; set; }

        // Navigation property for User
        public Users User { get; set; }

        // Many-to-many relation with Pet
        public ICollection<Pets> Pets { get; set; } = new List<Pets>();
    }
}
