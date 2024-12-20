﻿using GameCharacterDatabase.Models;

namespace GameCharacterDatabase.DTOs
{
	public record struct InventoryCreateDTO(string description, List<Item> Items);
}
