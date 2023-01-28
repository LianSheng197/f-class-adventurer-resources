using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterGroup")]
public class DesignCharacterGroup : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _characterGroup;

		public int _characterId;

		public float _positionX;

		public float _positionY;

		public Character GetCharacter(DesignStage.Data designStage)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, List<Data>> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public List<Data> GetData(int characterGroup)
	{
		return null;
	}
}
