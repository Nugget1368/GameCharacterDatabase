using GameCharacterDatabase.Data;
using GameCharacterDatabase.DTOs;
using GameCharacterDatabase.Models;
using GameCharacterDatabase.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Server.Services
{
	public partial class DbService
	{ 
		public async Task<ResultModel<List<Character>>> GetAllCharactersAsync()
		{
			var result = new ResultModel<List<Character>>();
			try
			{
				result.Result = await context.Characters
					.Include(c => c.Inventory.Items)
					.Include(c => c.Weapons)
					.Include(c => c.Factions)
					.ToListAsync();
				if (result.Result is not null)
				{
					result.Success = true;
					return result;
				}
				return new ResultModel<List<Character>>() { ResultMessage = "Could not find any Characters" };

			}
			catch (Exception ex)
			{
				result.ResultMessage = ex.Message;
				result.Success = false;
				return result;
			}
		}
		public async Task<ResultModel<Character>> CreateCharacterAsync(CharacterCreateDTO request)
		{
			var result = new ResultModel<Character>();
			var newCharacter = new Character
			{
				Name = request.Name
			};
			var inventory = new Inventory
			{
				Description = request.Inventory.description,
				Character = newCharacter
			};
			var items = request.Inventory.Items.Select(item => new Item { Name = item.Name }).ToList();
			var weapons = request.Weapons.Select(weapon => new Weapon { Name = weapon.Name, Character = newCharacter }).ToList();
			var factions = request.Factions.Select(faction => new Faction { Name = faction.Name, Characters = new List<Character> { newCharacter } }).ToList();

			newCharacter.Inventory = inventory;
			newCharacter.Weapons = weapons;
			newCharacter.Factions = factions;
			newCharacter.Inventory.Items = items;

			try
			{
				context.Characters.Add(newCharacter);
				await context.SaveChangesAsync();
				result.Success = true;
				result.ResultMessage = "Character Added!";
				return result;
			}
			catch (Exception ex)
			{
				result.Success = false;
				result.ResultMessage = ex.Message;
				return result;
			}
		}
	}
}
