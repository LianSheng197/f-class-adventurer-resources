using UnityEngine;

[AddComponentMenu("WWW/WWWRemoveChatBlock")]
public class WWWRemoveChatBlock : WWWData
{
	protected override AckParam Ack()
	{
		return null;
	}
}
