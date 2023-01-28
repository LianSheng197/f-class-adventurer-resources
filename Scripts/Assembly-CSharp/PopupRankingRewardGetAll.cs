using UnityEngine;

[AddComponentMenu("Popup/PopupRankingRewardGetAll")]
public class PopupRankingRewardGetAll : PopupBase
{
	public void Init(ReceivePrevBossRankingRewardResult receivePrevBossRankingRewardResult)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private int SortOrder(int worldIdA, int worldIdB)
	{
		return 0;
	}
}
