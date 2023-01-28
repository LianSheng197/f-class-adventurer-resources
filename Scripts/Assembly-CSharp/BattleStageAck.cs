using System.Collections.Generic;

public class BattleStageAck : BattleAckParam
{
	public bool _isWin;

	public bool _isAbusing;

	public Stage _stage;

	public string _exp;

	public List<ItemReward> _firstRewards;

	public List<InstantShop> _instantShop;

	public int _beforeWorldRank;

	public int _afterWorldRank;

	public List<AdsData> _adsList;
}
