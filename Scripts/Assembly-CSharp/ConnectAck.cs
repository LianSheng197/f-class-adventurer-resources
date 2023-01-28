using System;
using System.Collections.Generic;

[Serializable]
public class ConnectAck : AckParam
{
	public string _requestKey;

	public string _userKey;

	public bool _bCreated;

	public string _aosPublicKey;

	public string _aosPayLoad;

	public string _oneStorePublicKey;

	public string _oneStorePayload;

	public List<IntegrationReq.LoginType> _alreadyIntegrations;

	public List<string> _alreadyIntegrationKeys;

	public accountPermission.eType _accountPermission;

	public bool _isFirstLogin;

	public bool IsJoinedGuild;

	public List<RetentionPushReward> _retentionPushRewardList;
}
