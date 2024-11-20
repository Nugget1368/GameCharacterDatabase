namespace GameCharacterDatabase.Models
{
	public class Character
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Inventory Inventory { get; set; }
		public List<Weapon>	Weapons { get; set; }
		public List<Faction> Factions { get; set; }
	}
}
