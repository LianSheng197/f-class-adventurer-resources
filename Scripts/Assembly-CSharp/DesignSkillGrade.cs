using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillGrade")]
public class DesignSkillGrade : TableBase
{
	[Serializable]
	public class Data
	{
		public int _skillGrade;

		public int _name;

		public float _battlePointLevelValue;

		public float _battlePointFameValue;

		public Color _textColor;

		public Color _bgGradientTop;

		public Color _bgGradientBottom;
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

	public Data GetData(int skillGrade)
	{
		return null;
	}
}
