using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCommonLanguage")]
public class DesignCommonLanguage : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public string _value_korean;

		public string _value_english;

		public string _value_chinese;

		public string _value_chinese_Simple;

		public string _value_japanese;

		public string _value_french;

		public string _value_russian;

		public string _value_portuguese;

		public string _value_german;

		public string _value_spanish;

		public string _value_thai;

		public string _value_italian;

		public string _value_indonesian;

		public string _value_vietnamese;

		public string _value_turkish;

		public string _value_hindi;

		public string _value => null;

		public string GetLanguageValue()
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

	public string GetString(int id)
	{
		return null;
	}

	public string GetKorean(int id)
	{
		return null;
	}
}
