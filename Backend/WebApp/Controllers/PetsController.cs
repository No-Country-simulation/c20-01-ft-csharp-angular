using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetsController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/pets
        [HttpGet]
        public async Task<ActionResult<ListPetsDTO>> GetPets()
        {
            try
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
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocurrió un error al obtener las mascotas");
            }
        }

        // GET /api/pets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<IdPetDTO>> GetPetById(string id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
                return NotFound();

            var idPetDTO = new IdPetDTO()
            {
                PetId = pet.PetId,
                PetName = pet.PetName,
                PetSpecies = pet.PetSpecies,
                PetAge = pet.PetAge,
                Description = pet.Description
            };

            return Ok(idPetDTO);
        }

        // POST /api/pets
        [HttpPost]
        public async Task<ActionResult<PetsTDO>> RegisterPets([FromBody] PetsTDO registerPets)
        {
            var pet = new Pets
            {
                PetId = Guid.NewGuid().ToString(),
                PetName = registerPets.PetName,
                PetSpecies = registerPets.PetSpecies,
                PetAge = registerPets.PetAge,
                Description = registerPets.Description,
                Created = DateTime.UtcNow
            };

            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();

            var response = new PetsTDO
            {
                PetId = pet.PetId,
                PetName = pet.PetName,
                PetSpecies = pet.PetSpecies,
                PetAge = pet.PetAge,
                Description = pet.Description,
                Created = pet.Created
            };

            return CreatedAtAction(nameof(RegisterPets), new { id = response.PetId }, response);
        }

        // PUT /api/pets/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePet(string id, [FromBody] PetsTDO updatedPet)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            pet.PetName = updatedPet.PetName;
            pet.PetSpecies = updatedPet.PetSpecies;
            pet.PetAge = updatedPet.PetAge;
            pet.Description = updatedPet.Description;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE /api/pets/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePet(string id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
                return NotFound();

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
