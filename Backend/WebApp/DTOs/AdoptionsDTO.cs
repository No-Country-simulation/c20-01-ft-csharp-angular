using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DTOs
{
	public class AdoptionsDTO
	{
		public string? AdoptionId { get; set; }
		public DateTime AdoptionDate { get; set; } = DateTime.UtcNow;
		public string Status { get; set; } = "pending";
		public string UserId { get; set; }
	}
}