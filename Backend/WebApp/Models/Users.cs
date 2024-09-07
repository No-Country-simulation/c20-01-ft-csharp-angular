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
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string UserPassword { get; set; }
		[Required]
		public string UserEmail { get; set; }
		public DateTime Created { get; set; } = DateTime.UtcNow;

		/*
		// Navigation property for adoptions
		public ICollection<Adoptions> Adoptions { get; set; }


		// Navigation property for reviews
		public ICollection<Reviews> Reviews { get; set; }*/
	}
}
