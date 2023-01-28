using UnityEngine;

public class AndroidPluginManager : MonoBehaviour
{
	private static AndroidPluginManager _instance;

	public static bool _init;

	private const int IABHELPER_ERROR_BASE = -1000;

	private const int IABHELPER_REMOTE_EXCEPTION = -1001;

	private const int IABHELPER_BAD_RESPONSE = -1002;

	private const int IABHELPER_VERIFICATION_FAILED = -1003;

	private const int IABHELPER_SEND_INTENT_FAILED = -1004;

	private const int IABHELPER_USER_CANCELLED = -1005;

	private const int IABHELPER_UNKNOWN_PURCHASE_RESPONSE = -1006;

	private const int IABHELPER_MISSING_TOKEN = -1007;

	private const int IABHELPER_UNKNOWN_ERROR = -1008;

	private const int IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = -1009;

	private const int IABHELPER_INVALID_CONSUMPTION = -1010;

	private const int BILLING_RESPONSE_RESULT_OK = 0;

	private const int BILLING_RESPONSE_RESULT_USER_CANCELED = 1;

	private const int BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 3;

	private const int BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 4;

	private const int BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 5;

	private const int BILLING_RESPONSE_RESULT_ERROR = 6;

	private const int BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 7;

	private const int BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 8;

	public static AndroidPluginManager GetInstance()
	{
		return null;
	}

	public void init()
	{
	}

	private void InAppInitResult_J(string strResult)
	{
	}

	private void illegalError(string strFunc)
	{
	}

	private void InAppBuyItemResult_J(string strResult)
	{
	}

	private void InAppConsumeResult_J(string strResult)
	{
	}
}
