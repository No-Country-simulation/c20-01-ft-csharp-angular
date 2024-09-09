using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.DTOs;

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
		public async Task<ActionResult<AdoptionsDTO>> CreateAdoption(AdoptionsDTO adoption)
		{
			return adoption;
		}
	}
}