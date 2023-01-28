using System.Collections.Generic;
using UnityEngine;

public class EventViewCardSelectOpen : MonoBehaviour
{
	private DesignCardEvent.Data _designCardEvent;

	private bool _isCardOpenFirst;

	private GameObject _cardPosition;

	private GameObject _beforeStart;

	private UIButton _nextBtn;

	private UILabel _nextCostLabel;

	private Dictionary<int, GameObject> _objList;

	public void InitView(bool isCardOpenFirst, int designId)
	{
	}

	public void UpdateView()
	{
	}

	private void UpdateCost()
	{
	}

	public void CardOpen(int slot)
	{
	}

	private void InitInfo()
	{
	}

	private void ChangeCardEffectFirst()
	{
	}

	private void EndEffect(GameObject obj)
	{
	}

	private void ChangeCardEffect()
	{
	}

	private void EndChangeCardEffect(GameObject obj)
	{
	}

	private void MakeCard()
	{
	}

	private void MakeBeforeCard()
	{
	}

	private void SelectCard(UIButton btn)
	{
	}

	private void RequestNext(bool isFirst)
	{
	}

	private void Message(UIButton btn)
	{
	}

	private void AskNext(GameObject obj, UIButton btn)
	{
	}
}
