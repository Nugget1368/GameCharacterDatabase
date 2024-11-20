namespace GameCharacterDatabase.DTOs
{
	public record struct CharacterCreateDTO(string Name, InventoryCreateDTO Inventory, List<WeaponCreateDTO> Weapons, List<FactionCreateDTO> Factions);
}
