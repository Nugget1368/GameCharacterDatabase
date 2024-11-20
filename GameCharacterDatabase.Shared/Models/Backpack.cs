using System.Text.Json.Serialization;

namespace GameCharacterDatabase.Models
{
	public class Inventory
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public List<Item> Items { get; set; }
		public int CharacterId { get; set; }
		[JsonIgnore]
		public Character Character { get; set; }
	}
}
