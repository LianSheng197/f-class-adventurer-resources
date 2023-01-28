using System.Collections.Generic;
using UnityEngine;

public class IncreaseGauge : MonoBehaviour
{
	public delegate void GaugeDelegate();

	public delegate void GaugeMaxDelegate(long value);

	private GaugeDelegate _gaugeCallback;

	private GaugeMaxDelegate _gaugeMaxCallback;

	private bool _isPlay;

	private UISlider _slider;

	private UILabel _label;

	private int _index;

	private List<IncreaseGaugeData> _increaseList;

	private float _lerpTime;

	private float _duration;

	private GameObject _effectRoot;

	private GameObject _effectPrefab;

	public static IncreaseGauge Add(GameObject gameObject)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void Clear()
	{
	}

	public void SetDuration(float duration)
	{
	}

	public void SetLabel(UILabel label)
	{
	}

	public void SetPrefab(GameObject root, GameObject prefab)
	{
	}

	public void SetCallback(GaugeDelegate gaugeCallback)
	{
	}

	public void SetMaxCallback(GaugeMaxDelegate gaugeMaxCallback)
	{
	}

	public void AddData(List<IncreaseGaugeData> datas)
	{
	}

	public void AddData(IncreaseGaugeData data)
	{
	}

	public void SetPlay(bool isPlay)
	{
	}

	public void StartIncrease()
	{
	}

	private void Update()
	{
	}
}
