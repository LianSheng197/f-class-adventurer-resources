using System;
using System.Collections.Generic;
using UnityEngine;

public class AutoRequest : MonoBehaviour
{
	public class Config
	{
		public long _maxReqCount;

		public bool _isDaily;

		public float _startDelaySeconds;

		public float _intervalSeconds;

		public List<string> _activeSceneList;

		public Config(long maxReqCount = long.MaxValue, bool isDaily = true, float startDelaySeconds = 0f, float intervalSeconds = 300f, List<string> activeSceneList = null)
		{
		}

		public static bool Check(AutoRequestData data, float deltaTime)
		{
			return false;
		}
	}

	private static AutoRequest _Instance;

	private Dictionary<string, AutoRequestData> _reqList;

	public const float _updateInterval = 5f;

	private float _time;

	public static AutoRequest Instance => null;

	private void Update()
	{
	}

	public static void Add(Type type, Config config = null)
	{
	}

	private void AddRequest(Type type, Config config)
	{
	}

	private void CleanUpData(AutoRequestData data)
	{
	}

	public void CleanUp(bool checkCount = false)
	{
	}
}
