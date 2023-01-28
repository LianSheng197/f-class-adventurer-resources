using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/EventSpecialMission")]
public class EventSpecialMission : EventView
{
	public delegate void IAPDelegate(bool isResult, IAPData iapData);

	private Dictionary<int, GameObject> _tabList;

	private int _selectTab;

	private DesignShop.Data _designShop;

	private UIGrid _grid;

	private UIScrollView _scrollView;

	private Transform _allGetBtn;

	private GameObject _buyInfo;

	private Transform _focusReward;

	private bool _bInit;

	public static bool _isLock;

	public void InitTabList()
	{
	}

	public void Init()
	{
	}

	public void SelectTab(int selectTab)
	{
	}

	public void UpdateList()
	{
	}

	public void CheckNew()
	{
	}

	public void OnChangeTab(UIButton btn)
	{
	}

	public bool IsCompleteCriteria()
	{
		return false;
	}

	public void AllGetBtn(UIButton btn)
	{
	}

	private void Message(UIButton btn)
	{
	}

	private void OnCallback(WWWData wwwData)
	{
	}

	public void IsBuyPremium(GameObject obj, UIButton btn)
	{
	}

	public void BuyPremium(UIButton btn)
	{
	}

	public static void Lock()
	{
	}

	public static void UnLock()
	{
	}

	private void DownLoadEnvironment()
	{
	}

	private void EndEnvironment(bool isResult, string strResult)
	{
	}

	public bool Buy(int count)
	{
		return false;
	}

	private void WWWBuyCallBack(WWWData ack)
	{
	}

	public void BuyByIAP(bool isResult, IAPData iapData)
	{
	}
}
