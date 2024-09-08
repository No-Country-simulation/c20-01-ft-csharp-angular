using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
	public class Adoptions
	{
		public string AdoptionId { get; set; }
		public DateTime AdoptionDate { get; set; } = DateTime.UtcNow;
		public string Status { get; set; } = "pending";

		public string UserId { get; set; }
		public string PetId { get; set; }

		// Navigation property for User
		public Users User { get; set; }

		// Many-to-many relation with Pet
		public ICollection<Pets> Pets { get; set; }
	}
}
