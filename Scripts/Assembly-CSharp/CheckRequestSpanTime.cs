using System;
using System.Collections.Generic;

public class CheckRequestSpanTime
{
	private class CompareData
	{
		public DateTime _enqueueTime;

		public Type _classType;
	}

	private static Dictionary<Type, CompareData> _dicCheck;

	private const int _validMilliSeconds = 400;

	public static void CheckDicClear()
	{
	}

	public static bool Check(WebFormat data)
	{
		return false;
	}

	public static bool IsCheck(Type type)
	{
		return false;
	}
}
