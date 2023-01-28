using System.Collections.Generic;

public class GetCharacterMagicAck : AckParam
{
	public struct CharacterMagic
	{
		public int designID;

		public int characterID;

		public byte positionNo;

		public bool isLocked;
	}

	public List<CharacterMagic> characterMagics;
}
