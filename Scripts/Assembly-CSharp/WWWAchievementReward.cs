public class WWWAchievementReward : WWWData
{
	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
