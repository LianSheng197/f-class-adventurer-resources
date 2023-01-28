using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupCollection")]
public class PopupCollection : PopupBase
{
	public enum Filter
	{
		Legend = 0,
		Relic = 1,
		KeepMark = 2,
		Stone = 3,
		Treasure = 4,
		Artifact = 5,
		Max = 6
	}

	private RadioGroup _radioGroup;

	private Filter _curFilter;

	private Dictionary<Filter, CollectionViewBase> _viewList;

	private UIGrid _moneyPosition;

	public void InitPopup()
	{
	}

	public override void UpdateItem()
	{
	}

	public override void UpdateNew()
	{
	}

	public void UpdateView()
	{
	}

	public void ViewOff()
	{
	}

	public void ViewIn()
	{
	}

	public void AckState(CollectionViewBase.AckState ackState, int id = 0)
	{
	}

	private void SelectFilter(string name)
	{
	}

	private bool CheckFilter(string select)
	{
		return false;
	}

	private void InitAutoCurrency()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public override void PopupCloseCall()
	{
	}
}
