public class WWWGetStorage : WWWData
{
	public void Req(Storage.eType type = Storage.eType.NormalStorage)
	{
	}

	protected override AckParam Ack()
	{
		return null;
	}
}
