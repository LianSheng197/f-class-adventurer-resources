using System;
using UnityEngine;

public class ShopCard : MonoBehaviour
{
	protected DesignShop.Data _data;

	protected BuyBtnComponent _btnComp;

	private InstantShop _InstantShop;

	private GameObject _new;

	private DateTime _rewardTime;

	private GameObject _soldOut;

	public void Init(DesignShop.Data data)
	{
	}

	public void Init(DesignShop.Data data, InstantShop InstantShop)
	{
	}

	protected void InitUI()
	{
	}

	public void UpdateUI()
	{
	}

	private void UpdateAdsCoolTime()
	{
	}

	public void Update()
	{
	}

	public void Select(UIButton btn)
	{
	}
}
