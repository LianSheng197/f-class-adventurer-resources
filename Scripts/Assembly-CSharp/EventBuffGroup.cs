using System;
using System.Collections.Generic;

[Serializable]
public class EventBuffGroup
{
	public long _groupId;

	public bool _isInvisible;

	public int _orderNumber;

	public int _name;

	public List<int> _characterConditionList;

	public Dictionary<EventBuff.type, List<EventBuff>> _buffList;

	public List<EventBuff> _clientBuffList;

	public DateTime _startTime;

	public DateTime _endTime;

	public int _dayOfWeek;

	public bool IsDayOfWeek(DateTime curTime)
	{
		return false;
	}
}
