public class WWWGetMyGuildInfo : WWWData
{
	public bool _isNotification;

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
