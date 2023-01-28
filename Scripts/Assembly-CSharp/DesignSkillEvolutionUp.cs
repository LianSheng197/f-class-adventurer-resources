using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillEvolutionUp")]
public class DesignSkillEvolutionUp : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _evolutionUpType;

		public int _evolution;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public int _maxLevel;

		public int _battlePointLevel;

		public List<ContentsFunctionData> _contentsFunctionData;

		public float _levelUpPriceMultiply;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}

		public Data Next()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _evolutionData;

	public List<int> _needTypeList;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetData(int evolutionUpType, int evolution)
	{
		return null;
	}

	public int MaxEvolutionUp(int evolutionUpType)
	{
		return 0;
	}

	public int MaxLevel(int evolutionUpType, int evolution)
	{
		return 0;
	}
}
