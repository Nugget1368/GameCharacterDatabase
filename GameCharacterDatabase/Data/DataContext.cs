using GameCharacterDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace GameCharacterDatabase.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Character> Characters { get; set; }
		public DbSet<Inventory> Inventorys { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Weapon> Weapons { get; set; }
		public DbSet<Faction> Factions { get; set; }
	}
}
