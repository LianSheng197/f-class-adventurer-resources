using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupItemSellConfirm")]
public class PopupItemSellConfirm : PopupBase
{
	public enum SellType
	{
		Relic = 1,
		Skill = 2,
		Legend = 3,
		KeepMark = 4
	}

	private List<ItemReward> _sellList;

	private Dictionary<int, long> _sellListBackup;

	private Dictionary<int, long> _rewardList;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UIGrid _moneyGird;

	private Transform _FunctionChange;

	private SellType _sellType;

	public void InitPopup(Dictionary<int, long> sellList, SellType sellType)
	{
	}

	private void ChangeFunctionChange(bool isAll)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
