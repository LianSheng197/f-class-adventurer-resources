using System.Collections.Generic;

public class CharacterMagicManager
{
	private Dictionary<int, List<GetCharacterMagicAck.CharacterMagic>> _dicMagicData;

	public void Clear()
	{
	}

	public void SetMagicList(List<GetCharacterMagicAck.CharacterMagic> characterMagics)
	{
	}

	public void SetMagic(int characterID, List<AssignCharacterMagicAck.CharacterMagic> characterMagics)
	{
	}

	public void SetMagic(int characterID, GetCharacterMagicAck.CharacterMagic characterMagic)
	{
	}

	public void SetLockMagic(int characterId, int positionNo, bool isLock)
	{
	}

	public List<GetCharacterMagicAck.CharacterMagic> GetMagicList(int characterId)
	{
		return null;
	}

	public bool GetMagicData(int characterId, int idx, ref GetCharacterMagicAck.CharacterMagic magicData)
	{
		return false;
	}

	public List<int> GetMagicIdList(int characterId)
	{
		return null;
	}

	public int GetLockCount(int characterId)
	{
		return 0;
	}
}
