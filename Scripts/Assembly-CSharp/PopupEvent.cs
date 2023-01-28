using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupEvent")]
public class PopupEvent : PopupBase
{
	public class SortData
	{
		public EventList _eventList;

		public MissionData _missionData;

		public DesignCardEvent.Data _designCardEvent;
	}

	private GameObject _prefabTab;

	private UIGrid _grid;

	private GameObject _bannerRoot;

	private List<EventTab> _eventTabList;

	private EventTab _selectTab;

	private EventView _eventView;

	private EventViewCardOpen _eventViewCardOpen;

	private EventViewCardSelectOpen _eventViewCardSelectOpen;

	private MissionView _missionView;

	public static UILabel _timeLabel;

	public static UILabel _bannerTimeLabel;

	private EventList.buttonType _buttonType;

	public void InitPopup(EventList.buttonType buttonType)
	{
	}

	public void SelectTab(EventTab tab)
	{
	}

	public void UpdateTabState()
	{
	}

	public EventView CurrentEventView()
	{
		return null;
	}

	public void InitView(bool isCardOpenFirst = false)
	{
	}

	public void InitViewSpecialMission()
	{
	}

	public void UpdateSpecialMission()
	{
	}

	public void CardOpen(int slot)
	{
	}

	public static void EndEvent()
	{
	}

	private void InvokeEndEvent()
	{
	}

	private void FirstSelect()
	{
	}

	public void UpdateView()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
