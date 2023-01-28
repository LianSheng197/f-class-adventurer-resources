using System.Collections.Generic;

public class CharacteristicManager
{
	private static CharacteristicManager _Instance;

	private Dictionary<int, CharacteristicData> _list;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static CharacteristicManager Instance => null;

	public void SetList(List<CharacteristicData> list)
	{
	}

	public void SetCharacteristic(CharacteristicData characteristic, bool contentsFunctionDataUpdate = true)
	{
	}

	public CharacteristicData GetCharacteristic(int id)
	{
		return null;
	}

	public int GetCharacteristicLevel(int id)
	{
		return 0;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public bool IsLevelUp(int id)
	{
		return false;
	}
}
