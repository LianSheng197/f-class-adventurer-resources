using System.Collections.Generic;
using UnityEngine;

public class NoticeMsg : MonoBehaviour
{
	private static NoticeMsg _instance;

	private Dictionary<int, NoticeInfo> _readList;

	private NoticeInfo _workData;

	private Queue<NoticeInfo> _workQueue;

	private UISprite _background;

	private UILabel _msg;

	private float _width;

	private float _widthHalf;

	private int _showCount;

	public static NoticeMsg Instance => null;

	public static void Add(List<NoticeInfo> list)
	{
	}

	private void Update()
	{
	}

	public static void Hide()
	{
	}

	public void Init()
	{
	}

	public void Add(NoticeInfo notice)
	{
	}

	public void ShowNotice(NoticeInfo notice)
	{
	}

	public void HideNotice()
	{
	}

	private void Rewind()
	{
	}

	private void Finish()
	{
	}
}
