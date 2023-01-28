using UnityEngine;

[AddComponentMenu("Popup/PopupGuildBoss")]
public class PopupGuildBoss : PopupBase
{
	private DesignWorld.Data _designWorld;

	private GameObject _rankItemPrefab;

	private UIScrollView _scrollview;

	private UIGrid _grid;

	private Transform _leftInfoRoot;

	private Transform _rightInfoRoot;

	private int _currentBossLevel;

	private bool _isRefershReq;

	private GetMyGuildBossRankingAck _ack;

	private Color _originalBattlePointColor;

	private bool _isShowAds;

	public void InitPopup(GetMyGuildBossRankingAck ack)
	{
	}

	private void InitStatus()
	{
	}

	public void UpdateButtons()
	{
	}

	private void UpdateRanking()
	{
	}

	private void UpdateMyRank()
	{
	}

	private void UpdateGuildUserList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	private void UpdateRankItem(Transform obj, GuildMemberBossRankingInfo rankInfo)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void CallbackDailyReward(WWWData data)
	{
	}

	private void UpdateRankReward()
	{
	}

	public static void UpdateRankLabel(UILabel staticLabel, UILabel rankLabel, double point)
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}
}
