using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class AdError
	{
		private IAdErrorClient client;

		public AdError(IAdErrorClient client)
		{
		}

		public int GetCode()
		{
			return 0;
		}

		public string GetDomain()
		{
			return null;
		}

		public string GetMessage()
		{
			return null;
		}

		public AdError GetCause()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
