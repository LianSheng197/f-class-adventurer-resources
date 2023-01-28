using System;
using System.Collections.Generic;

[Serializable]
public class GachaData
{
	public enum eType
	{
		normal = 1,
		item = 2
	}

	public int _idx;

	public int _groupId;

	public int _characterId;

	public int _characterSeed;

	public short _type;

	public short _count;

	public bool _pickUp;

	public List<int> _bonusRewardGivePoint;

	public List<int> _bonusRewardSeed;

	public GachaData Copy()
	{
		return null;
	}
}
