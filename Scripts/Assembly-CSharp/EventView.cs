using System;
using UnityEngine;

public class EventView : MonoBehaviour
{
	protected int _id;

	protected DateTime _curTime;

	protected EventTab _eventTab;

	protected virtual void GetData()
	{
	}

	public virtual void InitView(int id, EventTab tab)
	{
	}

	public virtual void UpdateView()
	{
	}

	public virtual void UpdateRemainTimeLabel()
	{
	}
}
