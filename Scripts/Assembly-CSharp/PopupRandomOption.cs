using System.Collections.Generic;
using MathNet.Numerics.Random;
using UnityEngine;

[AddComponentMenu("Popup/PopupRandomOption")]
public class PopupRandomOption : PopupBase
{
	private const float AUTO_TIME = 0.3f;

	private RandomOption.eType _type;

	private int _itemId;

	private UIGrid _randomOptionGrid;

	private GameObject _prefabLabel;

	private UILabel _haveEffectOn;

	private UILabel _haveEffectOff;

	private UILabel _haveEffectOpenCondition;

	private Transform _randomOptionBtnOn;

	private Transform _randomOptionBtnOff;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private Transform _autoIng;

	private UISprite _autoCostSprite;

	private UILabel _autoCostLabel;

	private int _randomOptionCount;

	private float _autoTime;

	private int _autoGrade;

	private List<int> _autoContentsFunctionIds;

	private List<int> _openConditionList;

	private int _openCondition;

	private int _randomOptionType;

	private int _randomOptionPriceType;

	private DesignRandomOptionHaveEffect.Data _designRandomOptionHaveEffect;

	private MonoBehaviour _updateTarget;

	private Xorshift _randomFunc;

	private void Update()
	{
	}

	public void InitPopup(RandomOption.eType type, int itemId, MonoBehaviour updateTarget)
	{
	}

	private void UpdateBaseInfo()
	{
	}

	private void UpdateView()
	{
	}

	private void UpdateView(bool isEffect)
	{
	}

	public override void UpdateItem()
	{
	}

	public DesignRandomOptionPrice.Data GetRandomOptionPrice()
	{
		return null;
	}

	private void UpdateBtnState()
	{
	}

	private void OnLock(UIButton btn)
	{
	}

	public void Ack(bool isAutoStop)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void EmptySlot()
	{
	}

	public bool CheckExceptionAllLock()
	{
		return false;
	}

	private bool CheckException()
	{
		return false;
	}

	private void AskRandomOption(GameObject obj, UIButton btn)
	{
	}

	private bool AsyncLevelUp()
	{
		return false;
	}

	private void RequestAsync(UIButton btn)
	{
	}

	private void SetRandomFunc()
	{
	}

	private void OnRandomOption(UIButton btn)
	{
	}

	public void SetAuto(int grade, List<int> selectContentsFunctionIds)
	{
	}
}
