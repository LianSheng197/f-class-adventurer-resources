using System;

public class WWWGetLastStorage : WWWData
{
	public static DateTime _lastGetTime;

	protected override AckParam Ack()
	{
		return null;
	}

	public static void AddReq()
	{
	}
}
