using System.Collections.Generic;

public class GetGachaRecordAck : AckParam
{
	public List<GachaRecord> _list;

	public List<GachaRecordReward> _rewards;
}
