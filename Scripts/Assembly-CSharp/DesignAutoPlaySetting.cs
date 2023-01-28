using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignAutoPlaySetting")]
public class DesignAutoPlaySetting : TableBase
{
	[Serializable]
	public class Data
	{
		public int _state;

		public float _riskMinimumValue;

		public float _riskMaximumValue;

		public int _bookedAllySummonSecond;

		public float _airMonsterRate;

		public float _airAttackAvailableAllyRate;

		public float _autoSkillUseRateCondition;

		public float _autoTopSkillTimeCondition;

		public float _stoneUpgradeRate;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int state)
	{
		return null;
	}

	public Data FindData(float stageRate)
	{
		return null;
	}
}
