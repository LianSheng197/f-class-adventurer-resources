using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorldEventBoss_DealReward")]
public class PopupWorldEventBoss_DealReward : PopupBase
{
	public class DealRewardData
	{
		public DesignEventDealReward.Data.DealType _type;

		public UIScrollView _scrollView;

		public UIWrapContent.OnInitializeItem _updateItem;

		public List<DesignEventDealReward.Data> _data;
	}

	private DesignWorld.Data _designWorld;

	private Dictionary<DesignEventDealReward.Data.DealType, DealRewardData> _dealRewardData;

	private GameObject _prefab;

	private Transform _getAll;

	public void InitPopup(int worldId)
	{
	}

	public void UpdateView()
	{
	}

	private bool IsAllGet()
	{
		return false;
	}

	private void UpdateMaximumList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	private void UpdateAccumulateList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	private void UpdateItem(int index, GameObject obj, DesignEventDealReward.Data designEventDealReward)
	{
	}

	private void FirstFocus()
	{
	}

	private void FocusFinish()
	{
	}

	private void SelectReward(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
