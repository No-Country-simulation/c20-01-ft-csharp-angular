using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
	[ApiController]
	[Route("api/adoptions")]
	public class AdoptionsController : ControllerBase
	{
		private readonly AppDbContext _context;

		public AdoptionsController(AppDbContext context)
		{
			_context = context;
		}

		// POST /api/adoptions
		[HttpPost]
		public async Task<ActionResult<AdoptionsDTO>> CreateAdoption([FromBody] AdoptionsDTO adoption)
		{
			var newAdoptionId = Guid.NewGuid().ToString();

			if (string.IsNullOrEmpty(adoption.UserId))
				return BadRequest("UserId is required.");

			var userExists = await _context.Users.FindAsync(adoption.UserId);
			if (userExists == null)
				return BadRequest("User does not exist.");

			var adoptions = new Adoptions
			{
				AdoptionId = newAdoptionId,
				AdoptionDate = adoption.AdoptionDate,
				Status = adoption.Status,
				UserId = adoption.UserId
			};

			_context.Adoptions.Add(adoptions);
			await _context.SaveChangesAsync();

			var response = new AdoptionsDTO
			{
				AdoptionId = newAdoptionId,
				AdoptionDate = adoptions.AdoptionDate,
				Status = adoptions.Status,
				UserId = adoptions.UserId
			};

			return CreatedAtAction(nameof(CreateAdoption), new { id = response.AdoptionId }, response);
		}
	}
}
