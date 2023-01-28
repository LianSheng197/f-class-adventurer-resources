using System;
using System.Collections.Generic;

public class DBGameConfig
{
	public class Data
	{
		public string _key;

		public DateTime _startTime;

		public DateTime _endTime;

		public string _rawValue;

		public bool _isActive;

		public bool IsActive => false;

		public string _strValue => null;

		public int _value => 0;
	}

	public static List<Data> _list;

	public static string GetStr(string key)
	{
		return null;
	}

	public static int GetInt(string key)
	{
		return 0;
	}

	private static Data Get(string key)
	{
		return null;
	}
}
