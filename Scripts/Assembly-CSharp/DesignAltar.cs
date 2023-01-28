using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignAltar")]
public class DesignAltar : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int level;

		public SpriteData _sprite;

		public long needExp;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int multiplyExp;

		private static DesignAltar _designDA;

		private static int _maxLevel;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public Data PrevLevel()
		{
			return null;
		}

		public Data NextLevel()
		{
			return null;
		}

		public int MaxLevel()
		{
			return 0;
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public long GetReqExp(long curExp)
		{
			return 0L;
		}

		public void GetContentsFunctionData(long exp, ref List<ContentsFunctionData> list)
		{
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

	public Data GetLevel(long exp)
	{
		return null;
	}

	public Data GetMaxLevel()
	{
		return null;
	}
}
