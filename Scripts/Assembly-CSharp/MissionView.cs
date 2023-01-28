using System.Collections.Generic;
using UnityEngine;

public class MissionView : MonoBehaviour
{
	private UILabel _titleLabel;

	private UILabel _remainEndDate;

	private UILabel _remainReplayDate;

	private UIGrid _grid;

	protected EventTab _eventTab;

	private GameObject _prefabMission;

	private int _missionId;

	private List<MissionProgressData> _sortMissionProgressList;

	private void OnEnable()
	{
	}

	public void InitMissionView(int missionId, EventTab tab)
	{
	}

	public void UpdateMissionProgress()
	{
	}

	public void AllGet(UIButton btn)
	{
	}

	public void UpdateRemainTimeLabel()
	{
	}
}
