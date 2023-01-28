using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterMagic")]
public class DesignCharacterMagic : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _magicGrade;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int _seed;

		public SpriteData _iconSprite;
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

	public int GetMaxCount()
	{
		return 0;
	}
}
