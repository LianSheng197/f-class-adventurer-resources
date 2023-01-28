using System.Collections.Generic;
using UnityEngine;

public class WorldViewEvent : WorldViewBase
{
	private List<StageManager.ScheduleData> _dataList;

	private Dictionary<int, GameObject> _objList;

	private StageManager.ScheduleData _selectScheduleData;

	public override void Init()
	{
	}

	public override void MakeList()
	{
	}

	public override void UpdateView()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public override void InitSelect(int worldId, int stage)
	{
	}

	public void AckNext()
	{
	}

	private void SelectWorld(UIButton btn)
	{
	}

	private void SelectFocus(int worldId)
	{
	}

	private void ShowSelect()
	{
	}
}
