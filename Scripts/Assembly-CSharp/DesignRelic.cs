using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRelic")]
public class DesignRelic : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _relicGroup;

		public int _name;

		public SpriteData _sprite;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public float _needItemRubyValue;

		public List<ContentsFunctionData> _contentsFunctionData;

		public Dictionary<int, long> _needItem;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public void CalcData()
		{
		}

		public List<ContentsFunctionData> GetContentsFunction(int level)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicGroupData;

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

	public List<Data> FindGroup(int group)
	{
		return null;
	}
}
