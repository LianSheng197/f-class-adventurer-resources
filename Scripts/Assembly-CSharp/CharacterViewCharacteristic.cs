using System.Collections.Generic;
using UnityEngine;

public class CharacterViewCharacteristic : MonoBehaviour
{
	public enum AckState
	{
		Get = 0,
		LevelUp = 1,
		Max = 2
	}

	private UIScrollView _scrollView;

	private UISprite _drag;

	private Dictionary<int, GameObject> _objList;

	private Transform _detailInfo;

	private Transform _cardPosition;

	private UILabel _namelabel;

	private UILabel _lvlabel;

	private UILabel _description;

	private UILabel _maxDescription;

	private UILabel _afterDescription;

	private GameObject _afterArrow;

	private UILabel _levelCondition;

	private Transform _learnBtn;

	private Transform _lvUpBtn;

	private Transform _lvMax;

	private GameObject _effectPosition;

	private int _selectCharacteristicId;

	public void Init()
	{
	}

	public void UpdateView()
	{
	}

	public void Ack(AckState state)
	{
	}

	private void MakeList()
	{
	}

	private void Link()
	{
	}

	private void SelectCharacteristic(UIButton btn)
	{
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	public bool IsClose()
	{
		return false;
	}

	private void Message(UIButton btn)
	{
	}
}
