using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupAchivement")]
public class PopupAchievement : PopupBase
{
	public enum TabType
	{
		ACCOUNT = 1,
		CHARACTER = 2,
		BATTLE = 3
	}

	private GameObject _prefabAchievement;

	private Transform _allGetBtn;

	private UIScrollView _scrollView;

	private List<AchievementData> _achievementProgressList;

	private TabType _selectTab;

	private Dictionary<TabType, GameObject> _tabList;

	public void InitPopup()
	{
	}

	public void UpdateViewList()
	{
	}

	private void UpdateViewList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void AllGetBtn(UIButton btn)
	{
	}

	private void SelectTab(string select)
	{
	}

	private void ChangeTab()
	{
	}

	public void CheckCategoryNew()
	{
	}
}
