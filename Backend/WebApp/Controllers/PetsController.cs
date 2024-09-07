using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/pets")]
	[ApiController]
	public class PetsController : ControllerBase
	{
		private readonly AppDbContext _context;

		public PetsController(AppDbContext context)
		{
			_context = context;
		}

		// GET api/pets/all
		[HttpGet("all")]
		public async Task<ActionResult<ListPetsDTO>> GetPet()
		{
			var pets = await _context.Pets.ToListAsync();
			var petsDTO = pets.Select(pets => new ListPetsDTO()
			{
				PetId = pets.PetId,
				PetName = pets.PetName,
				PetSpecies = pets.PetSpecies,
				PetAge = pets.PetAge,
				Description = pets.Description
			}).ToList();
			return Ok(petsDTO);
		}

		// POST api/pets/register
		[HttpPost("register")]
		public async Task<ActionResult<PetsResponseTDO>> RegisterPets([FromBody] PetsResponseTDO registerPetsDTO)
		{
			// Create a new Pet entity from the DTO
			var pet = new Pets
			{
				PetId = Guid.NewGuid().ToString(),
				PetName = registerPetsDTO.PetName,
				PetSpecies = registerPetsDTO.PetSpecies,
				PetAge = registerPetsDTO.PetAge,
				Description = registerPetsDTO.Description,
				Created = DateTime.UtcNow  // Set creation time to current UTC
			};

			// Add the new pet to the database context
			_context.Pets.Add(pet);
			await _context.SaveChangesAsync();

			// Create a DTO to return in the response
			var response = new PetsResponseTDO
			{
				PetId = pet.PetId,
				PetName = pet.PetName,
				PetSpecies = pet.PetSpecies,
				PetAge = pet.PetAge,
				Description = pet.Description,
				Created = pet.Created
			};

			// Return the created pet with 201 Created status
			return CreatedAtAction(nameof(RegisterPets), new { id = response.PetId }, response);
		}

	}
}
