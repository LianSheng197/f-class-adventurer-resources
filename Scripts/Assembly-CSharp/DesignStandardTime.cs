using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignStandardTime")]
public class DesignStandardTime : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public SupportLanguage.Language _language;

		public string _strUTCVariables;

		public bool _interstitialFilter;

		public List<int> _unitNumber;

		public List<int> _unitMinNumber;

		public List<int> _unitText;

		private int _addMinutes;

		public string GetTime(DateTime timeUtC9, bool writeUTC)
		{
			return null;
		}

		public string GetTime(DateTime startTimeUTC9, DateTime endTimeUTC9, bool writeUTC)
		{
			return null;
		}

		public void CalcAddMinutesFromUTCVariables()
		{
		}
	}

	public List<Data> _data;

	public Dictionary<SupportLanguage.Language, Data> _dicData;

	public List<SupportLanguage.Language> _interstitialFilters;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(SupportLanguage.Language language)
	{
		return null;
	}

	public string GetStandardTime(SupportLanguage.Language language, DateTime timeUTC9, bool writeUTC = true)
	{
		return null;
	}

	public string GetStandardTime(SupportLanguage.Language language, DateTime startTimeUTC9, DateTime endTimeUTC9, bool writeUTC = true)
	{
		return null;
	}
}
