public class WWWCreateGuild : WWWData
{
	private bool _isAreadyJoin;

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
