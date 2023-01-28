using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class AdInspectorError : AdError
	{
		public enum AdInspectorErrorCode
		{
			ERROR_CODE_INTERNAL_ERROR = 0,
			ERROR_CODE_FAILED_TO_LOAD = 1,
			ERROR_CODE_NOT_IN_TEST_MODE = 2,
			ERROR_CODE_ALREADY_OPEN = 3
		}

		public AdInspectorError(IAdInspectorErrorClient client)
			: base(null)
		{
		}

		public new AdInspectorErrorCode GetCode()
		{
			return default(AdInspectorErrorCode);
		}
	}
}
