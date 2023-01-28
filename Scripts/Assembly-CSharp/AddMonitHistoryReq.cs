using System.Collections.Generic;

public class AddMonitHistoryReq : ReqParam
{
	public string _className;

	public long _clientDelayMS;

	public List<long> _clientValue;

	public List<long> _serverValue;
}
