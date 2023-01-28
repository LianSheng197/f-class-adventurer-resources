public class WWWDeleteGuild : WWWData
{
	private bool isFailed;

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
