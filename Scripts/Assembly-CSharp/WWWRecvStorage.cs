public class WWWRecvStorage : WWWData
{
	public void Req(Storage.eType type)
	{
	}

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
