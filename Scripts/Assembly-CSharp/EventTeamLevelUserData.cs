using System;
using System.Collections.Generic;

[Serializable]
public class EventTeamLevelUserData : EventUserData
{
	[Serializable]
	public class Reward
	{
		public bool _result;
	}

	public DateTime _startTime;

	public DateTime _progressTime;

	public int _startLevel;

	public List<Reward> _rewardList;
}
