using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignContentsFunctionList")]
public class DesignContentsFunctionList : TableBase
{
	[Serializable]
	public class Data
	{
		public DesignContentsFunction.Data.FunctionType _type;

		public int _condition;

		public int _order;

		public int _name;

		public string _value;
	}

	public List<Data> _data;

	public Dictionary<DesignContentsFunction.Data.FunctionType, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(DesignContentsFunction.Data.FunctionType Type)
	{
		return null;
	}
}
