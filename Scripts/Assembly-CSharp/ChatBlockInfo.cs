using System;

[Serializable]
public class ChatBlockInfo
{
	public string _userCode;

	public string _blockUserName;

	public string _strBlockTime;

	public DateTime _blockTime => default(DateTime);
}
