using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Pets
    {
        [Key]
        public string PetId { get; set; }
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public int PetAge { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        // Many-to-one relation to Adoption
        public string? AdoptionId { get; set; }
        public Adoptions Adoption { get; set; }
    }
}
