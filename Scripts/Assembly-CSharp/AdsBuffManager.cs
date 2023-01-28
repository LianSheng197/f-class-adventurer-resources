using System;
using System.Collections.Generic;

public class AdsBuffManager
{
	private bool _isInit;

	private Dictionary<int, AdsBuffData> _adsBuffList;

	private List<ContentsFunctionData> _contentsFunctionData;

	public DateTime _startTime;

	private List<DesignAdsBuff.Data> _autoBuffSortList;

	private int _checkIndex;

	public void Init(List<AdsBuffData> adsBuffDataList)
	{
	}

	public void Clear()
	{
	}

	public void UpdateAdsBuff(AdsBuffData adsBuffData)
	{
	}

	public void UpdateAdsBuff(List<AdsBuffData> adsBuffDataList)
	{
	}

	public Dictionary<int, AdsBuffData> GetAdsBuffList()
	{
		return null;
	}

	public AdsBuffData GetAdsBuffData(int buffType)
	{
		return null;
	}

	public DateTime GetStartTime()
	{
		return default(DateTime);
	}

	public void UpdateStartTime(int seconds)
	{
	}

	public void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public int GetActiveCount()
	{
		return 0;
	}

	public void InitAutoBuffSort()
	{
	}

	public void ChangeAutoBuffSort()
	{
	}

	public void CheckAutoEnable()
	{
	}

	private void PlayAdsCallback(WWWData data)
	{
	}
}
