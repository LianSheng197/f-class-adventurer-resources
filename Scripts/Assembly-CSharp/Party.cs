using System;
using System.Collections.Generic;

[Serializable]
public class Party
{
	public const int _useCharacterSlot = 9;

	public const int _maxCharacterSlot = 10;

	public const int _maxPartySlot = 8;

	public int _userId;

	public int _slot;

	public List<long> _charIdxList;
}
