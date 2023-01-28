public class WWWAcceptOrRefuseGuildMemberApplicant : WWWData
{
	private bool _isFailed;

	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
