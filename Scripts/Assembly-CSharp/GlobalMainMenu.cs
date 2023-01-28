using System.Collections.Generic;
using UnityEngine;

public class GlobalMainMenu : MonoBehaviour
{
	private Dictionary<string, GameObject> _selectList;

	private Dictionary<string, GameObject> _newList;

	private List<StageManager.ScheduleData> _checkNewWorldList;

	public void Init()
	{
	}

	public void IsNewMenu()
	{
	}

	public void SetWorldUI(int worldId)
	{
	}

	private bool IsNew(string name)
	{
		return false;
	}

	private bool IsCollectionNew()
	{
		return false;
	}

	private bool IsNewWorld()
	{
		return false;
	}

	private bool IsNewShop()
	{
		return false;
	}

	public void UpdateSelect()
	{
	}

	public void UpdateClearWorld()
	{
	}

	private void Message(UIButton btn)
	{
	}

	private void ChangedMenu()
	{
	}

	private void MenuToggle(string menu)
	{
	}
}
