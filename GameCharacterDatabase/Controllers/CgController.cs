using GameCharacterDatabase.Data;
using GameCharacterDatabase.DTOs;
using GameCharacterDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CgController : ControllerBase
	{
		private readonly DataContext context;
		public CgController(DataContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<Character>>> GetCharacters()
		{
			var Characters = await context.Characters
				.Include(c => c.Inventory)
				.Include(c => c.Weapons)
				.Include(c => c.Factions)
				.ToListAsync();

			return Ok(Characters);
		}

		[HttpPost]
		public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDTO request)
		{
			var newCharacter = new Character
			{
				Name = request.Name
			};
			var inventory = new Inventory
			{
				Description = request.Inventory.description,
				Character = newCharacter
			};
			var weapons = request.Weapons.Select(weapon => new Weapon { Name = weapon.Name, Character = newCharacter }).ToList();
			var factions = request.Factions.Select(faction => new Faction { Name = faction.Name, Characters = new List<Character> { newCharacter } }).ToList();

			newCharacter.Inventory = inventory;
			newCharacter.Weapons = weapons;
			newCharacter.Factions = factions;

			context.Characters.Add(newCharacter);
			await context.SaveChangesAsync();
			return Ok(await context.Characters.Include(c => c.Inventory).Include(c => c.Weapons).Include(c => c.Factions).ToListAsync());
		}
	}
}
