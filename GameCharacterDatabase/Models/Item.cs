using System.Text.Json.Serialization;

namespace GameCharacterDatabase.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int InventoryId { get; set; }
		[JsonIgnore]
		public Inventory? Inventory { get; set; }
	}
}
