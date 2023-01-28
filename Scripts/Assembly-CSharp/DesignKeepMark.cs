using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignKeepMark")]
public class DesignKeepMark : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int keepMarktype;

		public int needCharacterLevel;

		public List<int> needkeepMark;

		public bool hidden;

		public List<ContentsFunctionData> _contentsFunctionData;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public List<ContentsFunctionData> GetContentsFunction(int level)
		{
			return null;
		}

		private ContentsFunctionData MakeContentsFunction(ContentsFunctionData target, int level)
		{
			return null;
		}
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

	public Data GetData(int id)
	{
		return null;
	}
}
