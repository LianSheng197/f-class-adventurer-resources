using System;
using UnityEngine;

public class AutoRequestData : MonoBehaviour
{
	public long _reqCount;

	public double _reqTime;

	public DateTime _lastReqTime;

	public WWWData _www;

	public AutoRequest.Config _config;

	public void Init(Type type, AutoRequest.Config config)
	{
	}

	public void Release(bool Init)
	{
	}

	public void Process(float deltaTime)
	{
	}

	private T CopyComponent<T>(T original, GameObject destination) where T : WWWData
	{
		return null;
	}
}
