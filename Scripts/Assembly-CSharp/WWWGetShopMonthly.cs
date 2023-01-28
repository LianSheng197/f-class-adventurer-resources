using System;

public class WWWGetShopMonthly : WWWData
{
	public static DateTime _reqTime;

	public static bool IsReqAutoRefresh()
	{
		return false;
	}

	public static bool IsReq()
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
