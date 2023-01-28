using System;
using System.Runtime.CompilerServices;
using NotificationSamples;
using UnityEngine;

public class PushHandler : MonoBehaviour
{
	public enum HandlerDelegateType
	{
		InitializeEnd = 0
	}

	public delegate void GameHandlerDelegate();

	public enum PushIdRange
	{
		RetentionPushStart = 100000,
		RetentionPushEnd = 200000
	}

	private static PushHandler _instance;

	public string _deviceToken;

	public GameNotificationsManager _gameNotificationMgr;

	private const string channel_id = "1";

	private bool _initialize;

	public static PushHandler Instance => null;

	public event GameHandlerDelegate _delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Initialize()
	{
	}

	public void AddLocalPush(int id, string title, string msg, long second)
	{
	}

	public void DismissAllNotifications()
	{
	}

	public void AddLocalPush(int id, string title, string msg, DateTime alarmTime)
	{
	}

	public void CancelAllLocalPush()
	{
	}

	public void CancelLocalPush(int id)
	{
	}

	public void RegisterPush(GameHandlerDelegate del)
	{
	}

	public string GetDeviceToken()
	{
		return null;
	}

	public void RegisterEnd()
	{
	}
}
