public class IntegrationReq : ReqParam
{
	public enum LoginType
	{
		Guest = 0,
		Facebook = 1,
		GooglePlay = 2,
		GameCenter = 3,
		GoogleSign = 4,
		AppleSign = 5,
		Size = 6
	}

	public LoginType _integrationType;

	public string _integrationKey;

	public int _requestType;

	public string _aosAuth;

	public string _fbAuth;

	public string _appleSign;
}
