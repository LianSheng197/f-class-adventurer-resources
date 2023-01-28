using System.Collections.Generic;
using UnityEngine;

public class QuickNotice : MonoBehaviour
{
	private static QuickNotice _instance;

	private static UIPanel _panel;

	private const int _maxShowRow = 2;

	private GameObject _prefabMissionQuickNotice;

	private GameObject _prefabAchievementQuickNotice;

	private UIGrid _grid;

	private Dictionary<QuickNoticeInfo.NoticeType, List<int>> _noticeGroupList;

	public bool _isLock;

	public static QuickNotice Instance => null;

	public void Init()
	{
	}

	public void Lock()
	{
	}

	public void UnLock()
	{
	}

	public void Add(QuickNoticeInfo.NoticeType type, int value)
	{
	}

	private void AddNotice(GameObject target, QuickNoticeInfo.NoticeType type, int value)
	{
	}

	public void RefreshPosition()
	{
	}

	public void RemoveNotice()
	{
	}

	public static void Remove(GameObject obj)
	{
	}

	public static void RemoveALL()
	{
	}

	public void Test()
	{
	}
}
