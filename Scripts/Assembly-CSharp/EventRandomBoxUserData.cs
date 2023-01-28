using System;
using System.Collections.Generic;

[Serializable]
public class EventRandomBoxUserData : EventUserData
{
	[Serializable]
	public class Reward
	{
		public int _boxId;

		public DateTime _buyTime;
	}

	public List<Reward> _list;
}
