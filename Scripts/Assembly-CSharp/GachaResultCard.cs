using System.Collections.Generic;
using UnityEngine;

public class GachaResultCard : MonoBehaviour
{
	private Item _item;

	private int _effectType;

	private int _gachaDataType;

	private bool _isEquip;

	private bool _isJumpEffect;

	public void Init(int designId, long count, int gachaDataType, bool isJumpEffect, bool isSpeedUp = false)
	{
	}

	private void Init(Item item, int gachaDataType, bool isSpeedUp = false)
	{
	}

	private void OnEnable()
	{
	}

	public void Show(bool isAnimation, bool isCancelAni = false, Dictionary<string, bool> soundList = null)
	{
	}

	public void CancelAnimation()
	{
	}

	private int MakeEffectType(int grade)
	{
		return 0;
	}

	private void InitResult(int effectType, bool isSpeedUp = false)
	{
	}

	public bool IsAnimationPlaying()
	{
		return false;
	}
}
