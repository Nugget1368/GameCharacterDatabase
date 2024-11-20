namespace GameCharacterDatabase.DTOs
{
	public record struct CharacterCreateDTO(string Name, BackpackCreateDTO BackPack, List<WeaponCreateDTO> Weapons, List<FactionCreateDTO> Factions);
}
