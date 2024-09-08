using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
	public class Reviews
	{
		public string ReviewId { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		// Foreign Keys
		public string UserId { get; set; }
		public string PetId { get; set; }

		// Navigation properties
		public Users User { get; set; }
		public Pets Pet { get; set; }
	}
}
