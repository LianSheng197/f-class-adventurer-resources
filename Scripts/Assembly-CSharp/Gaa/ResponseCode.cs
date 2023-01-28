namespace Gaa
{
	public class ResponseCode
	{
		public const int RESULT_OK = 0;

		public const int RESULT_USER_CANCELED = 1;

		public const int RESULT_SERVICE_UNAVAILABLE = 2;

		public const int RESULT_BILLING_UNAVAILABLE = 3;

		public const int RESULT_ITEM_UNAVAILABLE = 4;

		public const int RESULT_DEVELOPER_ERROR = 5;

		public const int RESULT_ERROR = 6;

		public const int RESULT_ITEM_ALREADY_OWNED = 7;

		public const int RESULT_ITEM_NOT_OWNED = 8;

		public const int RESULT_FAIL = 9;

		public const int RESULT_NEED_LOGIN = 10;

		public const int RESULT_NEED_UPDATE = 11;

		public const int RESULT_SECURITY_ERROR = 12;

		public const int RESULT_BLOCKED_APP = 13;

		public const int RESULT_NOT_SUPPORT_SANDBOX = 14;

		public const int RESULT_EMERGENCY_ERROR = 99999;

		public const int ERROR_DATA_PARSING = 1001;

		public const int ERROR_SIGNATURE_VERIFICATION = 1002;

		public const int ERROR_ILLEGAL_ARGUMENT = 1003;

		public const int ERROR_UNDEFINED_CODE = 1004;

		public const int ERROR_SIGNATURE_NOT_VALIDATION = 1005;

		public const int ERROR_UPDATE_OR_INSTALL = 1006;

		public const int ERROR_SERVICE_DISCONNECTED = 1007;

		public const int ERROR_FEATURE_NOT_SUPPORTED = 1008;

		public const int ERROR_SERVICE_TIMEOUT = 1009;
	}
}
