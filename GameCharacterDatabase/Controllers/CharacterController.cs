using GameCharacterDatabase.Controllers;
using GameCharacterDatabase.DTOs;
using GameCharacterDatabase.Models;
using GameCharacterDatabase.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameCharacterDatabase.Server.Controllers
{
	public class CharacterController : CgController
	{
		public CharacterController(DbService dbService) : base(dbService)
		{
		}

		[HttpGet]
		public async Task<ActionResult<List<Character>>> GetAllCharacters()
		{
			var result = await dbService.GetAllCharactersAsync();
			if (result.Success)
			{
				return Ok(result.Result);
			}
			return BadRequest(result.ResultMessage);
		}

		[HttpPost]
		public async Task<ActionResult> CreateCharacter(CharacterCreateDTO request)
		{
			var result = await dbService.CreateCharacterAsync(request);
			if (result.Success)
			{
				return Ok(result.ResultMessage);
			}
			return BadRequest(result.ResultMessage);
		}
	}
}
