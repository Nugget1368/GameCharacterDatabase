using GameCharacterDatabase.Data;
using GameCharacterDatabase.DTOs;
using GameCharacterDatabase.Models;
using GameCharacterDatabase.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Server.Services
{
	public partial class DbService
	{
		protected readonly DataContext context;
		public DbService(DataContext context)
		{
			this.context = context;
		}

		
	}
}
