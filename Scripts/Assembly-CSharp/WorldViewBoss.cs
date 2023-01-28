using System.Collections.Generic;
using UnityEngine;

public class WorldViewBoss : WorldViewBase
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

	public override bool UpdateNew()
	{
		return false;
	}

	public override void Message(UIButton btn)
	{
	}

	public override void InitSelect(int worldId, int stage)
	{
	}

	public override void UpdateLevelUp()
	{
	}

	private void SelectWorld(UIButton btn)
	{
	}

	public void ShowBossScarecrow()
	{
	}

	private void SelectFocus(int worldId)
	{
	}
}
