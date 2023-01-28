using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupRanking")]
public class PopupRanking : PopupBase
{
	public class WorldRankingDataBase
	{
		public int _worldId;
	}

	public class WorldRankingData : WorldRankingDataBase
	{
		public WorldRankingResult _result;
	}

	public class BossRankingData : WorldRankingDataBase
	{
		public BossRankingResult _result;
	}

	private RadioGroup _radioGroup;

	private GameObject _noRanking;

	private GameObject _ranking;

	private GameObject _myRanking;

	private GameObject _prefabRankingSet;

	private WorldRankingData _worldRanking;

	private BossRankingData _bossRanking;

	private int _rankingListCount;

	private UIScrollView _scrollView;

	private Transform _grid;

	private GameObject _wait;

	private Transform _rewardButton;

	private Dictionary<int, WorldRankingDataBase> _worldRankingData;

	public void InitPopup(WWWData wwwData)
	{
	}

	public bool IsRewardNew()
	{
		return false;
	}

	private void SelectWorld(string select)
	{
	}

	private void SetRankingList(int worldId)
	{
	}

	private void UpdateItem(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	private void RequestRankingList(int worldId)
	{
	}

	private void OnWorldRankingCallback(WWWData wwwData)
	{
	}

	private WorldRankingDataBase ConvertData(WWWData wwwData)
	{
		return null;
	}

	private void AddRankingData(WWWData wwwData)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void OnRewardButton(UIButton btn)
	{
	}

	public override void UpdateNew()
	{
	}
}
