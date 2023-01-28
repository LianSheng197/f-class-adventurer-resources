using System;
using System.Collections.Generic;

public class BossDealRankingData
{
	public int _worldId;

	public DateTime _updateTime;

	public double _maxDamage;

	public double _sumDamage;

	public List<bool> _isRewards;

	public static BossDealRankingData ParseDatas(int worldId, DateTime updateTime, double maxDamage, double sumDamage, string strDatas)
	{
		return null;
	}

	public static List<bool> ParseDatas(string strDatas)
	{
		return null;
	}

	public static string ParseDatas(BossDealRankingData datas)
	{
		return null;
	}

	public static string ParseDatas(List<bool> isRewards)
	{
		return null;
	}

	public static string ParseDatas(List<int> isRewards)
	{
		return null;
	}
}
