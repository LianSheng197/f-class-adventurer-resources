using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupPotential")]
public class PopupPotential : PopupBase
{
	private int MAX_COUNT;

	private Dictionary<int, AutoCurrency> _currency;

	private Transform _aniRoot;

	private Transform _checkSkip;

	private Transform _locationRoot;

	private Transform _statRoot;

	private Character _character;

	private CheckConsume _checkConsume;

	private SimpleToolTip _toolTip;

	private bool _isPlayingEffect;

	private int _effectIdx;

	private List<GameObject> _effectList;

	public void InitPopup(Character character)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void CloseCallback(GameObject obj)
	{
	}

	private void ShowDetailToolTip(PotentialStatItem item)
	{
	}

	public void UpdateConsume(int holdCount, bool isUpdateEffect = false)
	{
	}

	public void ShowActiveEffect(List<PotentialLocationItem> updateLocationList)
	{
	}

	public void CallbackEffect(PotentialLocationItem d)
	{
	}

	public void UnlockTouch()
	{
	}

	public void LockPoint(GetCharacterMagicAck.CharacterMagic magic)
	{
	}

	public void ChangePoint(List<GetCharacterMagicAck.CharacterMagic> magicList)
	{
	}

	public void ChangePotential(int characterId)
	{
	}

	public void DoLock(UIButton btn)
	{
	}

	public void UpdatePotential()
	{
	}

	public void UpdatePotential(int idx)
	{
	}

	public void TestCallback()
	{
	}

	public override void UpdateCurrency()
	{
	}
}
