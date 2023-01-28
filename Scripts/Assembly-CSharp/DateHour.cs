using System;

[Serializable]
public class DateHour
{
	private DateTime _DateTime;

	public static DateHour MinValue => null;

	public static DateHour MaxValue => null;

	public int Hour => 0;

	public int Minute => 0;

	public bool Equals(DateHour obj)
	{
		return false;
	}

	public DateHour(DateTime DateTime)
	{
	}

	public static bool IsActive(DateHour startHour, DateHour endHour, DateTime curTime)
	{
		return false;
	}
}
