﻿using GameCharacterDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Character> Characters { get; set; }
		public DbSet<Backpack> Backpacks { get; set; }
	}
}