using GameCharacterDatabase.Data;
using GameCharacterDatabase.DTOs;
using GameCharacterDatabase.Models;
using GameCharacterDatabase.Server.Services;
using GameCharacterDatabase.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CgController : ControllerBase
	{
		protected readonly DbService dbService;
		public CgController(DbService dbService)
		{
			this.dbService = dbService;
		}
	}
}
