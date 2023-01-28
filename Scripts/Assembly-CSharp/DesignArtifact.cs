using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignArtifact")]
public class DesignArtifact : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _name;

		public SpriteData _sprite;

		public SpriteData _background;

		public List<ContentsFunctionData> _contentsFunctionData;
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
