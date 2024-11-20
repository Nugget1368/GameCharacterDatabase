using GameCharacterDatabase.Models;

namespace GameCharacterDatabase.DTOs
{
	public record struct ItemCreateDTO(string description, Inventory inventory);
}
