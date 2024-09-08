using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
	public class Pets
	{
		public string PetId { get; set; }
		public string PetName { get; set; }
		public string PetSpecies { get; set; }
		public int PetAge { get; set; }
		public string Description { get; set; }
		public bool Available { get; set; }
		public DateTime Created { get; set; } = DateTime.UtcNow;

		// Navigation property for reviews
		public ICollection<Reviews> Reviews { get; set; }

		// Many-to-one relation to Adoption
		public string? AdoptionId { get; set; }
		public Adoptions Adoption { get; set; }
	}
}
