using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
	public class Users
	{
		public string UserId { get; set; }
		public string UserName { get; set; }
		public string UserPassword { get; set; }
		public string UserEmail { get; set; }
		public DateTime Created { get; set; } = DateTime.UtcNow;

		// Navigation property for adoptions
		public ICollection<Adoptions> Adoptions { get; set; }

		// Navigation property for reviews
		public ICollection<Reviews> Reviews { get; set; }
	}
}
