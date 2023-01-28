using System.Collections.Generic;

public class ChangeNameAck : AckParam
{
	public string _prevUserName;

	public List<ItemReward> _rewardList;
}
