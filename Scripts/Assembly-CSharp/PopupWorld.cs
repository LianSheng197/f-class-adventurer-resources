using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorld")]
public class PopupWorld : PopupBase
{
	private DesignWorld.Data.WorldMapType _curFilter;

	private RadioGroup _radioGroup;

	private Dictionary<DesignWorld.Data.WorldMapType, WorldViewBase> _viewList;

	public void InitPopup(int returnStageId = 0)
	{
	}

	private void SelectFilter(string select)
	{
	}

	public WorldViewBase GetView(DesignWorld.Data.WorldMapType type)
	{
		return null;
	}

	public void UpdateView()
	{
	}

	public void UpdateLevelUp()
	{
	}

	public void RefreshWorldList()
	{
	}

	private void InitOtherWorld()
	{
	}

	public void UpdateFilterAlert()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
