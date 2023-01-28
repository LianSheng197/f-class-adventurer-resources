using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignAdsBuff")]
public class DesignAdsBuff : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _levelType;

		public int _buffTime;

		public int _limitTime;

		public SpriteData _sprite;

		public List<ContentsFunctionData> _contentsFunctionData;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public List<ContentsFunctionData> GetContentsFunction(int level)
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
