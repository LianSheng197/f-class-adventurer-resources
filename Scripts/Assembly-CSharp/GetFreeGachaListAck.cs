using System.Collections.Generic;

public class GetFreeGachaListAck : AckParam
{
	public List<GachaGroup> _list;

	public List<GachaRecord> _recordList;
}
