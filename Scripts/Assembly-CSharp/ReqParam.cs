using System;
using System.Collections.Generic;
using ekgames;

[Serializable]
public class ReqParam : WWWParam
{
	public ekgames.Version _version;

	public ePlatform _ePlatForm;

	public int _nLangType;

	public string _clientUDID;

	public List<EventBuffGroup> _activeBuffGroup;
}
