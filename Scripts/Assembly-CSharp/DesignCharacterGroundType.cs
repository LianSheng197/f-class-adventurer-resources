using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterGroundType")]
public class DesignCharacterGroundType : TableBase
{
	[Serializable]
	public class Data
	{
		public DesignCharacter.Data.GroundType _id;

		public int _name;

		public SpriteData _sprite;
	}

	public List<Data> _data;

	public Dictionary<DesignCharacter.Data.GroundType, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(DesignCharacter.Data.GroundType groundType)
	{
		return null;
	}
}
