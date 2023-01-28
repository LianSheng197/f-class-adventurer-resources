public class WWWGetJoinableGuildInfos : WWWData
{
	public bool _isAlreadyJoin;

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
