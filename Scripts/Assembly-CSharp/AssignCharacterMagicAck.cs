using System.Collections.Generic;

public class AssignCharacterMagicAck : AckParam
{
	public struct CharacterMagic
	{
		public int designID;

		public byte positionNo;
	}

	public List<CharacterMagic> assignedCharacterMagics;

	public List<Item> remainingItems;

	public List<ItemMoney> remainingItemMonies;
}
