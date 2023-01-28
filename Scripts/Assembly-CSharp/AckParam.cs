using System;
using System.Collections.Generic;
using ekgames;

[Serializable]
public class AckParam : WWWParam
{
	public WWWData.STATE _result;

	public string _resultValue;

	public BlockInfo _blockInfo;

	public Server _server;

	public List<long> _WWWAddMonitHistoryValue;
}
