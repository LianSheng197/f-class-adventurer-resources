using UnityEngine;

public class WWWGachaCharacter : WWWData
{
	protected override bool GetAckState(AckParam ack)
	{
		return false;
	}

	public void OnUpdate(GameObject obj, UIButton btn)
	{
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
